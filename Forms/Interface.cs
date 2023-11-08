﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsConexionBD
{
    public partial class Interface : Form
    {
        //Datos para la conexion
        static string CONNECTION_STRING = @"Data source = 79.143.90.12,54321;
                            Initial Catalog = MendozaDavidEmploye; Persist Security Info = true;
                            User Id = sa; Password = 123456789";
        private SqlConnection connection;

        public Interface()
        {
            InitializeComponent();
        }

        //Boton para abrir y cerrar la conexion a la BD
        private void butOpen_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();

                //Actualizamos interfaz
                labConexion.Text = "Conexión: ON";
                butClose.Visible = true;
                labSelec.Visible = true;
                cmbSeleccion.Visible = true;
                butOpen.Visible = false;
                labCabecera.Text = "Pulsar para cerrar la conexion";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Boton para cerrar la conexion a la BD
        private void butClose_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();

                //Actualizamos interfaz
                labConexion.Text = "Conexión: OFF";
                butOpen.Visible = true;
                labSelec.Visible = false;
                cmbSeleccion.Visible = false;
                butClose.Visible = false;
                labCabecera.Text = "Pulsar para abrir la conexion";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void cmbSeleccion_VisibleChanged(object sender, EventArgs e)
        {
            if (cmbSeleccion.Visible == false)
            {
                grbJobInsert.Visible = false;
                lstCosas.Visible = false;
                labListJobs.Visible = false;
                grbParametros.Visible = false;
            }
        }

        private void Seleccion_ValueChng(object sender, EventArgs e)
        {
            if (cmbSeleccion.SelectedIndex == 0)
            {
                labListJobs.Text = "Lista de empleados";
                lstCosas.Visible = true;
                labListJobs.Visible = true;
                grbParametros.Visible = true;
                grbJobInsert.Visible = false;
            }
            else if (cmbSeleccion.SelectedIndex == 1)
            {
                MostrarListaJobs();
                labListJobs.Text = "Lista de jobs";
                lstCosas.Visible = true;
                labListJobs.Visible = true;
                grbParametros.Visible = false;
                grbJobInsert.Visible = false;
            }
            else if (cmbSeleccion.SelectedIndex == 2)
            {
                lstCosas.Visible = false;
                labListJobs.Visible = false;
                grbParametros.Visible = false;
                grbJobInsert.Visible = true;
            }
        }

        //Boton para crear nuevo job
        private void butInsertJob_Click(object sender, EventArgs e)
        {
            //Comprobamos que la información es correcta
            if (decimal.TryParse(txtMaxSalary.Text, out decimal maxSalary) && decimal.TryParse(txtMinSalary.Text, out decimal minSalary) && txtJobTitle.Text != "")
                InsertJob(maxSalary,minSalary); //Esta funcion inserta el JOB a la base de datos
            else
                MessageBox.Show("Valores introducidos no validos");
            
            //Actualizamos la interfaz
            txtJobTitle.Text = null;
            txtMaxSalary.Text = null;
            txtMinSalary.Text = null;
        }

        //Funcion para INSERT en BD
        private void InsertJob(decimal maxSalary, decimal minSalary)
        {
            try
            {
                //Uso de PARAMETER para evitar SQL injections
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@name";
                param.Value = txtJobTitle.Text;

                string query = $"INSERT INTO jobs (job_title,min_salary,max_salary) " +
                                $"VALUES (@name,{maxSalary},{minSalary});" +
                                $"SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(param);
                object id = command.ExecuteScalar();

                //command.ExecuteNonQuery(); cuando no nos hace falta recuperar valores
                //command.ExecuteScalar(); cuando recuperas 1 valor
                //command.ExecuteReader(); cuando recuperas varios valores

                Job newJob = new Job(int.Parse(id.ToString()), txtJobTitle.Text, maxSalary, minSalary);

                MessageBox.Show("Job creado exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Muestra la lista de jobs
        private void MostrarListaJobs()
        {
            lstCosas.Items.Clear();

            foreach (Job job in SelectJobs())
                lstCosas.Items.Add(job);
        }

        //Creamos la lista extrayendo los datos de la BD
        private List<Job> SelectJobs()
        {
            List<Job> jobs = new List<Job>();

            string query = "SELECT * FROM jobs";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader records = command.ExecuteReader();

            while (records.Read())
            {
                int jobId = (int)records["job_id"];
                string jobName = (string)records["job_title"];
                decimal? minSalary = (decimal)records["min_salary"];
                decimal? maxSalary = (decimal)records["max_salary"];

                Job job = new Job(jobId, jobName, minSalary, maxSalary);

                jobs.Add(job);
            }

            return jobs;
        }
    }
}

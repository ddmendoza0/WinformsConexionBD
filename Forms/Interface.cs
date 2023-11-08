using System;
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
        ConexionBD connect = new ConexionBD();
        JobDAL jobDAL = new JobDAL();

        public Interface()
        {
            InitializeComponent();
        }

        //Boton para abrir y cerrar la conexion a la BD
        private void butOpen_Click(object sender, EventArgs e)
        {
            connect.AbrirConexion();

            //Actualizamos interfaz
            labConexion.Text = "Conexión: ON";
            butClose.Visible = true;
            labSelec.Visible = true;
            cmbSeleccion.Visible = true;
            butOpen.Visible = false;
            labCabecera.Text = "Pulsar para cerrar la conexion";
        }

        //Boton para cerrar la conexion a la BD
        private void butClose_Click(object sender, EventArgs e)
        {
            connect.CerrarConexion();

            //Actualizamos interfaz
            labConexion.Text = "Conexión: OFF";
            butOpen.Visible = true;
            labSelec.Visible = false;
            cmbSeleccion.Visible = false;
            butClose.Visible = false;
            labCabecera.Text = "Pulsar para abrir la conexion";
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
                jobDAL.InsertJob(txtJobTitle.Text ,maxSalary,minSalary); //Esta funcion inserta el JOB a la base de datos
            else
                MessageBox.Show("Valores introducidos no validos");
            
            //Actualizamos la interfaz
            txtJobTitle.Text = null;
            txtMaxSalary.Text = null;
            txtMinSalary.Text = null;
        }

        //Muestra la lista de jobs
        private void MostrarListaJobs()
        {
            lstCosas.Items.Clear();

            foreach (Job job in jobDAL.SelectJobs())
                lstCosas.Items.Add(job);
        }
    }
}

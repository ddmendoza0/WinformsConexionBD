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
        JobDAL jobDAL = new JobDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();

        public Interface()
        {
            InitializeComponent();
        }

        private void Seleccion_ValueChng(object sender, EventArgs e)
        {
            if (cmbSeleccion.SelectedIndex == 0)
            {
                MostrarListaEmps();
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

        private void MostrarListaEmps()
        {
            lstCosas.Items.Clear();

            foreach (Employee emp in employeeDAL.SelectEmps())
                lstCosas.Items.Add(emp);
        }
    }
}

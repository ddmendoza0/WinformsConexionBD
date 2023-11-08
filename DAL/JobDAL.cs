using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsConexionBD
{
    internal class JobDAL
    {
        ConexionBD connection = new ConexionBD();

        //Creamos la lista extrayendo los datos de la BD
        public List<Job> SelectJobs()
        {
            connection.AbrirConexion();

            List<Job> jobs = new List<Job>();

            string query = "SELECT * FROM jobs";
            SqlCommand command = new SqlCommand(query, connection.Connection);

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
            connection.CerrarConexion();

            return jobs;
        }

        //Funcion para INSERT en BD
        public void InsertJob(string jobTitle, decimal maxSalary, decimal minSalary)
        {
            try
            {
                //Uso de PARAMETER para evitar SQL injections
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@name";
                param.Value = jobTitle;

                string query = $"INSERT INTO jobs (job_title,min_salary,max_salary) " +
                                $"VALUES (@name,{maxSalary},{minSalary});" +
                                $"SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection.Connection);
                command.Parameters.Add(param);
                object id = command.ExecuteScalar();

                //command.ExecuteNonQuery(); cuando no nos hace falta recuperar valores
                //command.ExecuteScalar(); cuando recuperas 1 valor
                //command.ExecuteReader(); cuando recuperas varios valores

                Job newJob = new Job(int.Parse(id.ToString()), jobTitle, maxSalary, minSalary);

                MessageBox.Show("Job creado exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static object DBNullToNull(object val)
        {
            if (val == DBNull.Value)
                return null;
            else
                return val;
        }
        public static object NullToDBNull(object val)
        {
            if (val == null)
                return DBNull.Value;
            else
                return val;
        }

    }
}

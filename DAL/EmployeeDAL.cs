using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsConexionBD
{
    internal class EmployeeDAL
    {
        ConexionBD connection = new ConexionBD();

        //Creamos la lista extrayendo los datos de la BD
        public List<Employee> SelectEmps()
        {
            connection.AbrirConexion();

            List<Employee> emps = new List<Employee>();

            string query = "SELECT * FROM employees";
            SqlCommand command = new SqlCommand(query, connection.Connection);

            SqlDataReader rec = command.ExecuteReader();

            while (rec.Read())
            {
                //int jobId = (int)records["job_id"];
                //string jobName = (string)records["job_title"];
                //decimal? minSalary = (decimal)records["min_salary"];
                //decimal? maxSalary = (decimal)records["max_salary"];

                int idEmp = (int)rec["employee_id"];
                string firstNameEmp = (string)rec["first_name"];
                string lastNameEmp = (string)rec["last_name"];
                string emailEmp = (string)rec["email"];
                string phoneEmp = StringDBNullToNull(rec["phone_number"]);
                DateTime hireDateEmp = (DateTime)rec["hire_date"];
                int jobIdEmp = (int)rec["job_id"];
                decimal salaryEmp = (decimal)rec["salary"];
                int? managerIdEmp = IntDBNullToNull(rec["manager_id"]);
                int? departmentIdEmp = IntDBNullToNull(rec["department_id"]);

                Employee emp = new Employee(idEmp,firstNameEmp,lastNameEmp,emailEmp,phoneEmp,hireDateEmp,jobIdEmp,salaryEmp,managerIdEmp, departmentIdEmp);

                emps.Add(emp);
            }
            connection.CerrarConexion();

            return emps;
        }

        public List<Employee> SelectEmpsFiltros()
        {
            List<Employee> emps = new List<Employee>();

            return emps;
        }

        private static int? IntDBNullToNull(object val)
        {
            if (val == DBNull.Value)
                return null;
            else
                return (int)val;
        }
        private static string StringDBNullToNull(object val)
        {
            if (val == DBNull.Value)
                return null;
            else
                return (string)val;
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

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

        //
        //Creamos la lista extrayendo los datos de la BD
        //
        public List<Employee> SelectEmps()
        {
            connection.AbrirConexion();

            List<Employee> emps = new List<Employee>();

            string query = "SELECT * FROM employees";
            SqlCommand command = new SqlCommand(query, connection.Connection);

            SqlDataReader rec = command.ExecuteReader();

            while (rec.Read())
            {
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

        public List<Employee> SelectEmpsFiltros(string nombre, string apellido, string ciudad)
        {
            connection.AbrirConexion();
            List<Employee> emps = new List<Employee>();

            SqlParameter paramN = new SqlParameter();
            paramN.ParameterName = "@name";
            paramN.Value = nombre;

            SqlParameter paramL = new SqlParameter();
            paramL.ParameterName = "@lastname";
            paramL.Value = apellido;

            string query = @"SELECT * FROM employees e " +
                        "INNER JOIN departments d " +
                            "ON e.department_id = d.department_id " +
                        "INNER JOIN locations l " +
                            "ON d.location_id = l.location_id " +
                        "WHERE ";

            // comprobación de filtros actios
            if (ciudad != "")
            {
                query += $"l.city = '{ciudad}' AND ";
            }
            else if (nombre != null)
            {
                query += $"e.first_name = '{nombre}' AND ";
            }
            else if (apellido != null)
            {
                query += $"e.last_name = '{apellido}' AND ";
            }
            
            if (query.EndsWith(" "))
                query = query.Remove(query.Length - 4, 4);

            SqlCommand command = new SqlCommand(query, connection.Connection);
            SqlDataReader rec = command.ExecuteReader();

            while (rec.Read())
            {
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

                Employee emp = new Employee(idEmp, firstNameEmp, lastNameEmp, emailEmp, phoneEmp, hireDateEmp, jobIdEmp, salaryEmp, managerIdEmp, departmentIdEmp);

                emps.Add(emp);
            }
            connection.CerrarConexion();
            return emps;
        }
        //
        //Metodos de comprobacion de null
        //
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

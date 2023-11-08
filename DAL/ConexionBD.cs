using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsConexionBD
{
    internal class ConexionBD
    {
        static string CONNECTION_STRING = @"Data source = 79.143.90.12,54321;
                            Initial Catalog = MendozaDavidEmploye; Persist Security Info = true;
                            User Id = sa; Password = 123456789";
        private SqlConnection connection;
        public SqlConnection Connection { get { return connection; } set { connection = value; } }

        public ConexionBD() { }

        public void AbrirConexion()
        {
            try
            {
                Connection = new SqlConnection(CONNECTION_STRING);
                Connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CerrarConexion()
        {
            try
            {
                Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

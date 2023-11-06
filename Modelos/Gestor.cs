using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsConexionBD
{
    internal class Gestor
    {
        private List<Job> jobs;

        public List<Job> Jobs
        {
            get
            {
                if (jobs == null)
                    jobs = new List<Job>();
                return jobs;
            }
            set
            {
                jobs = value;
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsConexionBD
{
    internal class Job
    {
        private int jobId;
        private string jobTitle;
        private decimal? jobMinSalary;
        private decimal? jobMaxSalary;

        public int JobId { get { return jobId; } set { jobId = value; } }
        public string JobTitle { get { return jobTitle; } set { jobTitle = value; } }
        public decimal? JobMinSalary { get { return jobMinSalary; } set { jobMinSalary = value; } }
        public decimal? JobMaxSalary { get { return jobMaxSalary; } set { jobMaxSalary = value; } }

        public Job() { }

        public Job(string title, decimal? minSalary, decimal? maxSalary)
        {
            JobTitle = title;
            JobMinSalary = minSalary;
            JobMaxSalary = maxSalary;
        }

        public Job(int id, string title, decimal? minSalary, decimal? maxSalary)
        {
            JobId = id;
            JobTitle = title;
            JobMinSalary = minSalary;
            JobMaxSalary = maxSalary;
        }

        public override string ToString()
        {
            return $"ID {JobId}, " +
                $"{JobTitle}, " +
                $"Salary {JobMinSalary} - {JobMaxSalary}";
        }
    }
}

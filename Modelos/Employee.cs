using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WinformsConexionBD
{
    internal class Employee
    {
        private int idEmp;
        private string firstNameEmp;
        private string lastNameEmp;
        private string emailEmp;
        private string phoneEmp;
        private DateTime hireDateEmp;
        private int jobIdEmp;
        private decimal salaryEmp;
        private int? managerIdEmp;
        private int? departmentIdEmp;

        public int IdEmp {  get { return idEmp; } set {  idEmp = value; } }
        public string FirstNameEmp { get { return firstNameEmp; } set {  firstNameEmp = value; } }
        public string LastNameEmp { get { return lastNameEmp; } set {  lastNameEmp = value; } }
        public string EmailEmp { get { return emailEmp; } set {  emailEmp = value; } }
        public string PhoneEmp { get { return phoneEmp; } set {  phoneEmp = value; } }
        public DateTime HireDateEmp { get { return hireDateEmp; } set {  hireDateEmp = value; } }
        public int JobIdEmp { get { return jobIdEmp; } set {  jobIdEmp = value; } }
        public decimal SalaryEmp { get { return salaryEmp; } set {  salaryEmp = value; } }
        public int? ManagerIdEmp { get { return managerIdEmp; } set {  managerIdEmp = value; } }
        public int? DepartmentIdEmp { get { return departmentIdEmp; } set {  departmentIdEmp = value; } }
        
        public Employee()
        {

        }

        public Employee(int id, string fName, string lName, string email, string phone, DateTime hireDate, int idJob, decimal salary, int? idManager, int? idDepartment)
        {
            IdEmp = id;
            FirstNameEmp = fName; 
            LastNameEmp = lName;
            EmailEmp = email;
            PhoneEmp = phone;
            HireDateEmp = hireDate;
            SalaryEmp = salary;
            ManagerIdEmp = idManager;
            DepartmentIdEmp = idDepartment;
        }

        public override string ToString()
        {
            return $"{IdEmp}. " +
                $"{FirstNameEmp} " +
                $"{LastNameEmp} ";
        }
    }
}

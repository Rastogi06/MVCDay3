using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class EmpDept
    {
        Employee e1 = new Employee();
        private string _Firstname;

        public string Firstname
        {
            get { return e1.Firstname; }
            set { e1.Firstname = value; }
        }
        Departments d1 = new Departments();
        private string _DepartmentName;

        public string DepartmentName
        {
            get { return d1.DepartmentName; }
            set { d1.DepartmentName = value; }
        }


    }
}
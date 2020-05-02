using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models.prob
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Departmrg { get; set; }
        public string Pro { get; set; }
        public string DepartmentProb { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
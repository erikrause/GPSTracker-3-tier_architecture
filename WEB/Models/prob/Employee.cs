﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.Models.prob
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }
    }
}
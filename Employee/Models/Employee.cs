using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public long Password { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpLocation { get; set; }
    }
}
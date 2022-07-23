using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLibrary.Models
{
    public class EmployeeModel
    {
        public string EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Salary { get; set; }
    }
}
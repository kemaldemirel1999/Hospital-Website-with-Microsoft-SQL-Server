using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLibrary.Models
{
    public class PatientModel
    {
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLibrary.Models
{
    public class AppointmentModel
    {
        public string DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string ClinicName { get; set; }
        public string Pssn { get; set; }  
    }
}
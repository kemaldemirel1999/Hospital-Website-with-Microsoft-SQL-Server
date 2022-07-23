using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLibrary.Models
{
    public class PrescriptionModel
    {
        public string Pssn { get; set; }
        public string EmpId { get; set; }
        public DateTime Date { get; set; }
        public string Drug_name { get; set; }
        public DateTime Given_date { get; set; }
    }
}
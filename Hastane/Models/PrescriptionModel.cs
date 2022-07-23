using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class PrescriptionModel
    {
        [Display(Name = "Patient SSN")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string Pssn { get; set; }
        [Display(Name = "Doctor ID")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string EmpId { get; set; }
        [Display(Name = "Date")]
        [Required(ErrorMessage = "This field must be filled.")]
        [DataType(DataType.Date,ErrorMessage ="This field must be a date.")]
        public DateTime Date { get; set; }
        [Display(Name = "Drug Name")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Drug_name { get; set; }
        [Display(Name = "Given Date")]
        [Required(ErrorMessage = "This field must be filled.")]
        [DataType(DataType.Date, ErrorMessage = "This field must be a date.")]
        public DateTime Given_date { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class DoctorModel
    {
        [Display(Name = "Doctor ID")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string EmpId { get; set; }
        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Clinic_name { get; set; }
        [Display(Name = "Branch")]
        public string Branch { get; set; }
    }
}
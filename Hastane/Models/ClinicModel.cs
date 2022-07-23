using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class ClinicModel
    {
        [Display(Name = "Head Doctor ID")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string HeadDoctorId { get; set; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Location { get; set; }
        [Display(Name = "Clinic Name")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Name { get; set; }
    }
}
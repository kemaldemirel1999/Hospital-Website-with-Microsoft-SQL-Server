using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class LaborantModel
    {
        [Display(Name = "Employee ID")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string EmpId { get; set; }
        [Display(Name = "Laboratory No")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Lab_no { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace Hastane.Models
{
    public class NurseModel
    {
        [Display(Name = "Employee ID")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string EmpId { get; set; }
        [Display(Name = "Room No")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Room_responsible { get; set; }
    }
}
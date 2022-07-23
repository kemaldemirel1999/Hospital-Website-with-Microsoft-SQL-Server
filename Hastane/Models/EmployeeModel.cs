using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class EmployeeModel
    {
        [Display(Name = "Employee ID")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string EmployeeId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string FirstName { get; set; }
        [Display(Name = "Surname")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Surname { get; set; }
        [Display(Name = "Phone")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string Phone { get; set; }
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "This field must be filled.")]
        public char Gender { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Address { get; set; }
        [Display(Name = "Salary")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Salary { get; set; }
    }
}
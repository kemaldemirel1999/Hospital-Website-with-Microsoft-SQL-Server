using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class ManagerModel
    {
        [Display(Name = "Manager ID")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string EmpId { get; set; }
    }
}
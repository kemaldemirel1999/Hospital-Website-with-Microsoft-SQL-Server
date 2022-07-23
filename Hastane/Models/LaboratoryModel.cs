using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class LaboratoryModel
    {
        [Display(Name = "Room No")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Room_no { get; set; }
        [Display(Name = "Supervisor Name")]
        public string Supervisor_name { get; set; }
    }
}
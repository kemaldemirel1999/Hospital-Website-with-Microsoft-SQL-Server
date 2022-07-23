using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class PatientRoomModel
    {
        [Display(Name = "Room No")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Room_no { get; set; }
        [Display(Name = "Patient SSN")]
        [MinLength(10, ErrorMessage = "Must be 10 characters long.")]
        [MaxLength(10, ErrorMessage = "Must be 10 characters long.")]
        public string Pssn { get; set; }
        [Display(Name = "Capacity")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string Capacity { get; set; }
    }
}
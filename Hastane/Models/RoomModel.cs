using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hastane.Models
{
    public class RoomModel
    {
        [Display(Name = "Room No")]
        [Required(ErrorMessage = "This field must be filled.")]
        public string RoomNo { get; set; }
    }
}
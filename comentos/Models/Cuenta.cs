using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
namespace comentos.Models
{
    public class Cuenta
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

    }
}
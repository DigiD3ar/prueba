using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
namespace comentos.Models
{
    public class Comentario
    {
        [Required]
        public string email { get; set; }
        [Required]
        public DateTime fecha { get; set; }
        [Required]
        public int local { get; set; }

        [StringLength(150)]
        public string comentario { get; set; }
        [Range(1,5)]
        [Required]
        public int score { get; set; }

    }
}

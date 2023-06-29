using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Usuario
    {
        public string Contacto { get; set; }
        [Required]
        public string Password { get; set; }
        [Key]
        public string Nom_Usuario { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}

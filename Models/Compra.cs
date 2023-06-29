using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Compra
    {
        [Key]
        public int Nro_Compra { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public double Monto { get; set; }
        [Required]
        public int Cantidad_Compra { get; set; }

        //foraneas
        public Propietario Propietario { get; set; }
        public Producto Producto { get; set; }
    }
}

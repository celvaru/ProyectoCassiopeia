using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Detalle_Venta
    {
        [Required]
        public int Cantidad_Venta { get; set; }
        [Required]
        public double Precio_Venta { get; set; }
        [Key]
        public double Sub_Total { get; set; }

        //foraneas
        public Venta Venta { get; set; }
    }
}

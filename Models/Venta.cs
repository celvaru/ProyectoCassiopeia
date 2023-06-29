using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Venta
    {
        [Required]
        public DateTime Fecha { get; set; }
        [Key]
        public int Nro_Recibo { get; set; }
        [Required]
        public double Total { get; set; }

        //foraneas
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }

        //integridad referencial
        public List<Detalle_Venta> Detalle_Venta { get; set; }

    }
}

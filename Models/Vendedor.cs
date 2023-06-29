using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Vendedor:Usuario
    {
        public int CI { get; set; }
        //integridad referencial
        public List<Venta> Venta { get; set; }
    }
}

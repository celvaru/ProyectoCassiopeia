using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Propietario:Usuario
    {
        //integridad referencial
        public List<Compra> Compra { get; set; }
    }
}

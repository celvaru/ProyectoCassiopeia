using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required]
        public int CiCliente { get; set; }
        [Required]
        public string Nombre { get; set; }

        //integridad referencial
        public List<Venta> Venta { get; set; }

    }
}

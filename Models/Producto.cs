using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeluCenter.Models
{
    public class Producto
    {
        [Required]
        public int Bateria { get; set; }
        [Required]
        public int Camara { get; set; }
        [Required]
        public int Cantidad_Disp { get; set; }
        [Key]
        public int Codigo { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public Double Dimensiones { get; set; }
        public string Garantia { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public double Memoria { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public double Precio_Compra { get; set; }
        [Required]
        public double Precio_Venta { get; set; }
        [Required]
        public int Ram { get; set; }

        //integridad referencial
        public List<Compra> Compra { get; set; }
        public List<Detalle_Venta> Detalle_Venta { get; set; }
    }
}

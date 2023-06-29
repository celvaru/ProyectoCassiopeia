using CeluCenter.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CeluCenter.Context
{
    public partial class CompraVenta : DbContext
    {
        public CompraVenta()
            : base("name=CompraVenta")
        {
        }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Propietario> Propietario { get; set; }
        public virtual DbSet<Vendedor> Vendedor { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<Detalle_Venta> Detalle_Venta { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
    }
}

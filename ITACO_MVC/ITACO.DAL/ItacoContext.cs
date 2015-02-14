using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITACO.Model;

namespace ITACO.DAL
{
    public class ItacoContext : DbContext
    {
        public ItacoContext()
            : base("ItacoContext")
        {
        }

        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Producto_Tiene_Ingrediente> Producto_Tiene_Ingrediente { get; set; }
        public DbSet<TipoCantidad> TipoCantidad { get; set; }
        public DbSet<TipoProducto> TipoProducto { get; set; }
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Venta_Tiene_Producto> Venta_Tiene_Producto { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

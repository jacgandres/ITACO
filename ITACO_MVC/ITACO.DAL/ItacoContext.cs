using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
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

        public virtual List<Reporte_Ventas_Por_Fecha> Reporte_Ventas_Por_Fecha(DateTime? FechaInicio, DateTime? FechaFin)
        {
            object[] customerParameters = new object[2];
            customerParameters[0]= new SqlParameter("FechaInicio", FechaInicio.Value);
            customerParameters[1] = new SqlParameter("FechaFin", FechaFin.Value);

            return this.Database.SqlQuery<Reporte_Ventas_Por_Fecha>("Reporte_Ventas_Por_Fecha @FechaInicio,@FechaFin",
                customerParameters).ToList();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Reporte_Ventas_Por_Fecha>().MapToStoredProcedures();
        }
    }
}

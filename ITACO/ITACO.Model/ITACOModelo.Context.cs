﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ITACO.Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ITACOEntities : DbContext
    {
        public ITACOEntities()
            : base("name=ITACOEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ingrediente> Ingrediente { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Producto_Tiene_Ingrediente> Producto_Tiene_Ingrediente { get; set; }
        public virtual DbSet<TipoCantidad> TipoCantidad { get; set; }
        public virtual DbSet<TipoProducto> TipoProducto { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<Venta_Tiene_Producto> Venta_Tiene_Producto { get; set; }
    }
}

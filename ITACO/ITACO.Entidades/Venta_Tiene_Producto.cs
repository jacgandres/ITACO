//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Venta_Tiene_Producto
    {
        public long IdVenta { get; set; }
        public long IdProducto { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}

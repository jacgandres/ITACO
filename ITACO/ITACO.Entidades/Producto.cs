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
    using ITACO.Entidades.Wrapper;

    public partial class Producto : ProductoCore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Producto_Tiene_Ingrediente = new HashSet<Producto_Tiene_Ingrediente>();
            this.Venta_Tiene_Producto = new HashSet<Venta_Tiene_Producto>();
        }



        public virtual TipoProducto TipoProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_Tiene_Ingrediente> Producto_Tiene_Ingrediente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Tiene_Producto> Venta_Tiene_Producto { get; set; }
    }
}

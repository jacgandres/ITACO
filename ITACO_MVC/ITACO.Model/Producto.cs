using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class Producto
    {
        public Producto()
        {
            this.Producto_Tiene_Ingrediente = new HashSet<Producto_Tiene_Ingrediente>();
            this.Venta_Tiene_Producto = new HashSet<Venta_Tiene_Producto>();
        }

        public long ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public decimal ValorProducto { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public string TipoProductoID { get; set; }

        public virtual TipoProducto TipoProducto { get; set; } 
        public virtual ICollection<Producto_Tiene_Ingrediente> Producto_Tiene_Ingrediente { get; set; } 
        public virtual ICollection<Venta_Tiene_Producto> Venta_Tiene_Producto { get; set; }
    }
}

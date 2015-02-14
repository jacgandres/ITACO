using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class TipoProducto
    { 
        public TipoProducto()
        {
            this.Producto = new HashSet<Producto>();
        }

        public string TipoProductoID { get; set; }
        public string NombreTipoProducto { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
         
        public virtual ICollection<Producto> Producto { get; set; }
    }
}

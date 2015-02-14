using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class Venta_Tiene_Producto
    {
        public long Venta_Tiene_ProductoID { get; set; }
        public long VentaID { get; set; }
        public long ProductoID { get; set; }
        public System.DateTime FechaRegistro { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}

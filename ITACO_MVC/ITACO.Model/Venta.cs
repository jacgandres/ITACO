using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class Venta
    {
        public Venta()
        {
            this.Venta_Tiene_Producto = new HashSet<Venta_Tiene_Producto>();
        }

        public long VentaID { get; set; }
        public decimal ValorVenta { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public int Cantidad { get; set; }

        public virtual ICollection<Venta_Tiene_Producto> Venta_Tiene_Producto { get; set; }
    }
}

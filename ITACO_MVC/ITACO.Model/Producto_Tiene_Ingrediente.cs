using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class Producto_Tiene_Ingrediente
    {
        public long Producto_Tiene_IngredienteID { get; set; }
        public long IngredienteID { get; set; }
        public long ProductoID { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }

        public virtual Ingrediente Ingrediente { get; set; }
        public virtual Producto Producto { get; set; }
    }
}

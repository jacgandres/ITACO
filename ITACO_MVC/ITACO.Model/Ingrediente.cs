using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class Ingrediente
    { 
        public Ingrediente()
        {
            this.Producto_Tiene_Ingrediente = new HashSet<Producto_Tiene_Ingrediente>();
        }

        public long IngredienteID { get; set; }
        public string NombreIngrediente { get; set; }
        public System.DateTime FechaCompra { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorIngrediente { get; set; }
        public bool Estado { get; set; }
        public string IdMedida { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public int TipoCantidadID { get; set; }

        public virtual TipoCantidad TipoCantidad { get; set; } 
        public virtual ICollection<Producto_Tiene_Ingrediente> Producto_Tiene_Ingrediente { get; set; }
    }
}

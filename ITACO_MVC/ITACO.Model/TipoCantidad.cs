using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class TipoCantidad
    { 
        public TipoCantidad()
        {
            this.Ingrediente = new HashSet<Ingrediente>();
        }

        public int TipoCantidadID { get; set; }
        public string NombreTipoCantidad { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaRegistro { get; set; }
         
        public virtual ICollection<Ingrediente> Ingrediente { get; set; }
    }
}

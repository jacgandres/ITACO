using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Model
{
    public class Reporte_Ventas_Por_Fecha
    {
        public long ID{ get; set; } 
        public string NombreProducto { get; set; }
        public DateTime FechaRegistro { get; set;}
        public int Cantidad { get; set; }
        public decimal Suma { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITACO.Entidades.Wrapper
{
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class ProductoCore
    { 
        public long IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal ValorProducto { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
        public string IdTipoProducto { get; set; }
    }
}

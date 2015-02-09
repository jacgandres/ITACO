using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITACO.Entidades;
using ITACO.Model;

namespace ITACO.Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> ObtenerProductos()
        {
            using(ProductoDAO dao = new ProductoDAO())
            {
                return dao.ObtenerProductos();
            }
        }
    }
}

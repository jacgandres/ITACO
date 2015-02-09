using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITACO.Entidades;

namespace ITACO.Model
{
    public class ProductoDAO:IDisposable
    {
        public List<Producto> ObtenerProductos()
        {
            using(var contexto = new ITACOEntities())
            {
                List<Producto> productos = contexto.Producto.ToList();
                return productos;
            }
        }


        void IDisposable.Dispose()
        {
        }
    }
}

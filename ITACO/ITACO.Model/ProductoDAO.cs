using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITACO.Entidades;

namespace ITACO.Model
{
    public class ProductoDAO : IDisposable
    {
        public dynamic ObtenerProductos()
        {
            using (var contexto = new ITACOEntities())
            {
                var productos = from prod in contexto.Producto
                                select new
                                  {
                                      IdProducto = prod.IdProducto,
                                      Estado = prod.Estado,
                                      FechaRegistro = prod.FechaRegistro,
                                      IdTipoProducto = prod.IdTipoProducto,
                                      NombreProducto = prod.NombreProducto,
                                      ValorProducto = prod.ValorProducto
                                  };

                return productos.ToList();
            }
        }


        void IDisposable.Dispose()
        {
        }
    }
}

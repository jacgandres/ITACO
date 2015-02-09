using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITACO.Entidades;
using ITACO.Negocio;

namespace ITACOWEB
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio neg = new ProductoNegocio();

            foreach(Producto prod in neg.ObtenerProductos())
            {
                Response.Write(prod.NombreProducto);
            }

        }
    }
}
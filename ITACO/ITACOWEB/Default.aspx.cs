using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITACO.Entidades;
using ITACO.Entidades.Wrapper;
using ITACO.Negocio;
using Newtonsoft.Json;

namespace ITACOWEB
{
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.Web.Script.Services.ScriptService]
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static dynamic ObtenerProductos(string pAlgo)
        {
            try
            {
                using (ProductoNegocio neg = new ProductoNegocio())
                {
                    var algo = neg.ObtenerProductos();
                    string tmp = JsonConvert.SerializeObject(algo);
                    return algo;
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }


        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string HolaMundo()
        {
            return "Hola Mundo";
        }

        [WebMethod(EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public static string Temporal(string pAlgo)
        {
            ProductoCore producto = new ProductoCore();

            producto.Estado = true;
            producto.FechaRegistro = DateTime.Now;
            producto.IdProducto = 0;
            producto.IdTipoProducto = "AB";
            producto.NombreProducto = pAlgo;
            producto.ValorProducto = 1234578;

            return JsonConvert.SerializeObject(producto);
        }
    }
}
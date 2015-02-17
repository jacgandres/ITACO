using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ITACO.DAL;
using ITACO.Model;

namespace ITACO_MVC.Controllers
{
    public class Reporte_Ventas_Por_FechaController : Controller
    {
        private ItacoContext db = new ItacoContext();

        // GET: Reporte_Ventas_Por_Fecha
        public ActionResult Index(DateTime? FechaInicio, DateTime? FechaFin)
        {
            return View(db.Reporte_Ventas_Por_Fecha(DateTime.Now.AddDays(-9), DateTime.Now.AddDays(9)).ToList());
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

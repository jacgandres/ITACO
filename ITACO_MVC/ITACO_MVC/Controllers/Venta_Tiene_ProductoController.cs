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
    public class Venta_Tiene_ProductoController : Controller
    {
        private ItacoContext db = new ItacoContext();

        // GET: Venta_Tiene_Producto
        public ActionResult Index()
        {
            var venta_Tiene_Producto = db.Venta_Tiene_Producto.Include(v => v.Producto).Include(v => v.Venta);
            return View(venta_Tiene_Producto.ToList());
        }

        // GET: Venta_Tiene_Producto/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta_Tiene_Producto venta_Tiene_Producto = db.Venta_Tiene_Producto.Find(id);
            if (venta_Tiene_Producto == null)
            {
                return HttpNotFound();
            }
            return View(venta_Tiene_Producto);
        }

        // GET: Venta_Tiene_Producto/Create
        public ActionResult Create()
        {
            ViewBag.ProductoID = new SelectList(db.Producto, "ProductoID", "NombreProducto");
            ViewBag.VentaID = new SelectList(db.Venta, "VentaID", "VentaID");
            return View();
        }

        // POST: Venta_Tiene_Producto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Venta_Tiene_ProductoID,VentaID,ProductoID,FechaRegistro")] Venta_Tiene_Producto venta_Tiene_Producto)
        {
            if (ModelState.IsValid)
            {
                db.Venta_Tiene_Producto.Add(venta_Tiene_Producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ProductoID = new SelectList(db.Producto, "ProductoID", "NombreProducto", venta_Tiene_Producto.ProductoID);
            ViewBag.VentaID = new SelectList(db.Venta, "VentaID", "VentaID", venta_Tiene_Producto.VentaID);
            return View(venta_Tiene_Producto);
        }

        // GET: Venta_Tiene_Producto/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta_Tiene_Producto venta_Tiene_Producto = db.Venta_Tiene_Producto.Find(id);
            if (venta_Tiene_Producto == null)
            {
                return HttpNotFound();
            }
            ViewBag.ProductoID = new SelectList(db.Producto, "ProductoID", "NombreProducto", venta_Tiene_Producto.ProductoID);
            ViewBag.VentaID = new SelectList(db.Venta, "VentaID", "VentaID", venta_Tiene_Producto.VentaID);
            return View(venta_Tiene_Producto);
        }

        // POST: Venta_Tiene_Producto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Venta_Tiene_ProductoID,VentaID,ProductoID,FechaRegistro")] Venta_Tiene_Producto venta_Tiene_Producto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(venta_Tiene_Producto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ProductoID = new SelectList(db.Producto, "ProductoID", "NombreProducto", venta_Tiene_Producto.ProductoID);
            ViewBag.VentaID = new SelectList(db.Venta, "VentaID", "VentaID", venta_Tiene_Producto.VentaID);
            return View(venta_Tiene_Producto);
        }

        // GET: Venta_Tiene_Producto/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Venta_Tiene_Producto venta_Tiene_Producto = db.Venta_Tiene_Producto.Find(id);
            if (venta_Tiene_Producto == null)
            {
                return HttpNotFound();
            }
            return View(venta_Tiene_Producto);
        }

        // POST: Venta_Tiene_Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Venta_Tiene_Producto venta_Tiene_Producto = db.Venta_Tiene_Producto.Find(id);
            db.Venta_Tiene_Producto.Remove(venta_Tiene_Producto);
            db.SaveChanges();
            return RedirectToAction("Index");
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

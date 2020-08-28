using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewStoreSA.Models;

namespace NewStoreSA.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            DB_A669D6_storesa db = new DB_A669D6_storesa();

            List<Productos> lista = db.Productos.ToList();

            return View(lista);
        }

        public ActionResult Agregar()
        {
            return View();
        }
        
        //POST: Productos
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agregar(Productos a)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            try
            {
                using (var db = new DB_A669D6_storesa())
                {
                    db.Productos.Add(a);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error al agregar el producto.", e.Message);
                return View();
            }




        }
    }
}
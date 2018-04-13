using WebMantenedor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMantenedor.Controllers
{
    public class MantenedorPreciosController : Controller
    {
        // GET: Mantenedor
        public ActionResult Index()
        {
            ShippingPriceEntities db = new ShippingPriceEntities();
            //db.Precios.OrderByDescending
        
        
            db.Precios.ToList();
            return View(db.Precios.ToList());
        }
        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(Precios P)
        {
            if (!ModelState.IsValid)
                return View();
            return View();
        }
    }
}

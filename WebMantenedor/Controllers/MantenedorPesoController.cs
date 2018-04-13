using WebMantenedor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMantenedor.Controllers
{
    public class MantenedorPesoController : Controller
    {
        // GET: MantenedorPeso
        public ActionResult InicioPeso()
        {
            ShippingPriceEntities db = new ShippingPriceEntities();
            db.Peso.ToList();
            return View(db.Peso.ToList());
        }
    }
}
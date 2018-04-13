using WebMantenedor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMantenedor.Controllers
{
    public class MantenedorRegionController : Controller
    {
        // GET: MantenedorRegion
        public ActionResult InicioRegion()
        {
            ShippingPriceEntities db = new ShippingPriceEntities();
            db.Region.ToList();
            return View(db.Region.ToList());
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmadoFurniture.Models;

namespace AmadoFurniture.Models
{
    public class ShopController : Controller
    {
        


        NorthwindEntities db = new NorthwindEntities();
        // GET: Shop
        public ActionResult ShopIndex()
        {
            var liste = db.Products.Where(k => k.UnitsInStock >= 5 && k.UnitsInStock <= 10).ToList();
            var kategoriler = db.Categories.ToList();
            ViewBag.kategoriler = kategoriler;
            return View(liste);
        }
    }
}
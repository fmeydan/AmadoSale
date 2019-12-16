using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmadoFurniture.Areas.AdminPaneli.Controllers
{
    public class UrunlerController : Controller
    {
        // GET: AdminPaneli/Urunler
        public ActionResult UrunIndex()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmadoFurniture.Areas.AdminPaneli.Controllers
{
    public class AdminDefaultController : Controller
    {
        // GET: AdminPaneli/AdminDefault
        public ActionResult AdminIndex()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}
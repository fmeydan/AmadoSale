using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmadoFurniture.Models
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult AnasayfaIndex()
        {
            return View();
        }

        // GET: Default
        public ActionResult Test()
        {
            return View();
        }
      
    }
}
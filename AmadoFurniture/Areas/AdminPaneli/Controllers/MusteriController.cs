using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmadoFurniture.Areas.AdminPaneli.Models;

namespace AmadoFurniture.Areas.AdminPaneli.Controllers
{
    public class MusteriController : Controller
    {
        MusteriManage musteri_mng = new MusteriManage();
        // GET: AdminPaneli/Musteri
        public ActionResult MusteriIndex()
        {
            musteri_mng.FakeMusteriEkle();
            

            return View(musteri_mng.MusteriListesi());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmadoFurniture.Areas.AdminPaneli.Models;

namespace AmadoFurniture.Areas.AdminPaneli.Controllers
{
    public class PersonellerController : Controller
    {
        PersonelManage pers_mng = new PersonelManage();
        // GET: AdminPaneli/Personeller
        public ActionResult PersonelIndex()
        {
            
            return View(pers_mng.personelListesi());
        }

        
        public ActionResult personelEkle()
        {

            //Personeller ekleTablo = new Personeller();
           // ekleTablo.PersonelTC = ekle.PersonelTC;
           // ekleTablo.Adi = ekle.Adi;
            return View();
        }

        [HttpPost]
        public ActionResult personelEkle(Personeller ekle)
        {

            
            ViewBag.sonuc = pers_mng.PersonelEkle(ekle);
            return View();
        }


        public ActionResult PersonelDetay(int detayPID)
        {
            return View(pers_mng.PersonelDetay(detayPID).FirstOrDefault());
        }

        public ActionResult PersonelSil(int silPID)
        {
            return View(pers_mng.PersonelSil(silPID).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult PersonelSil(Personeller gelen)
        {
            
           ViewBag.SilSonuc = pers_mng.PersonelSil(gelen);
            return View();
            
        }

    }
}
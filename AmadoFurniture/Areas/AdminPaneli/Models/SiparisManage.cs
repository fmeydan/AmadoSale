using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmadoFurniture.Areas.AdminPaneli.Models
{
    public class SiparisManage
    {
        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }
        AmadFurnitureDBEntities db = new AmadFurnitureDBEntities();
        public void FakeSiparisEkle()
        {
            var SiparisSayisi = db.Siparisler.ToList();
            Random rnd = new Random();
            if (SiparisSayisi.Count() < 2500)
            {
                for (int i = 0; i < 2500; i++)
                {
                    Siparisler ekle = new Siparisler();
                    ekle.SiparisTarihi = RandomDay();
                    //ekle.SiparisTarihi = DateTime.Now;
                    //ekle.MusteriID = rnd.Next(1, 1000);
                    ekle.MusteriID = rnd.Next(1, 1000);
                    ekle.KargoAdi = FakeData.PlaceData.GetState();
                    ekle.KargoFiyati = Convert.ToDecimal(FakeData.NumberData.GetDouble());
                    db.Siparisler.Add(ekle);
                    db.SaveChanges();
                }
            }

        }

        public List<Siparisler> SiparisListesi()
        {
            return db.Siparisler.ToList();
        }
    }
}
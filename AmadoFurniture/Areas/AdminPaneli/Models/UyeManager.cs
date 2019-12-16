using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AmadoFurniture.Areas.AdminPaneli.Models
{
    public class UyeManager
    {
        AmadFurnitureDBEntities db = new AmadFurnitureDBEntities();
        public List<Uyeler> uyeListe()
        {

            return db.Uyeler.ToList();

        }


        public void ekle()
        {


            for (int i = 0; i <= 150; i++)
            {
                string isim = FakeData.NameData.GetFullName();
                string sifre = FakeData.TextData.GetAlphaNumeric(8);
                uyeEkle(isim, sifre);
            }

        }

        public void uyeEkle(string uyeAd, string sifre)
        {
            Uyeler ekle = new Uyeler();
            ekle.UyeAdi = uyeAd;
            ekle.Sifresi = sifre;
            db.Uyeler.Add(ekle);
            db.SaveChanges();



        }
    }
}

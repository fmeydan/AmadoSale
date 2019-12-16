using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmadoFurniture.Areas.AdminPaneli.Models
{
    public class MusteriManage
    {
        AmadFurnitureDBEntities db = new AmadFurnitureDBEntities();
        public void FakeMusteriEkle()
        {
            var MusteriSayisi = db.Musteriler.ToList();
            Random rnd = new Random();
            if (MusteriSayisi.Count() < 1000)
            {
                for (int i = 0; i < 1000; i++)
                {

                    Musteriler ekle = new Musteriler();
                    if (rnd.Next(0, 9) % 9 == 0)
                    {
                        ekle.MusteriAdi = FakeData.NameData.GetFemaleFirstName();
                        ekle.Cinsiyeti = "Kadın";
                    }
                    else
                    {
                        ekle.MusteriAdi = FakeData.NameData.GetMaleFirstName();
                        ekle.Cinsiyeti = "Erkek";
                    }
                    ekle.MusteriSoyadi = FakeData.NameData.GetSurname();
                    ekle.Telefon = FakeData.PhoneNumberData.GetPhoneNumber();
                    ekle.Epostasi = FakeData.NetworkData.GetEmail();
                    //ekle.Bolumu = FakeData.NameData.GetCompanyName();
                    ekle.Sehir = FakeData.PlaceData.GetCity();
                    //ekle.PersonelTC = FakeData.NumberData.GetNumber()
                    double tc = FakeData.NumberData.GetNumber(1000000000, 2147483647);
                    tc = tc * 10;
                    //if (tc>=10000000000)
                    //{
                    //    i++;
                    ekle.MusteriTC = tc.ToString();
                    ekle.DogumTarihi = RandomDay();
                    db.Musteriler.Add(ekle);
                    db.SaveChanges();
                    //}
                }
            }
        }

        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public List<Musteriler> MusteriListesi()
        {
            return db.Musteriler.ToList();
        }


    }
}
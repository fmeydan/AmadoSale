using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmadoFurniture.Areas.AdminPaneli.Models
{
    public class PersonelManage
    {
        AmadFurnitureDBEntities db = new AmadFurnitureDBEntities();
        public void fakeDataEkle()
        {
            
            var personelSayisi = db.Personeller.ToList();
            Random rnd = new Random();


            if (personelSayisi.Count()<50)
            {
                for (int i = 0; i < 50;i++)
                {
                    Personeller ekle = new Personeller();
                    

                    if (rnd.Next(0, 9) % 2 == 0)
                    {
                        ekle.Adi = FakeData.NameData.GetFemaleFirstName();
                        ekle.Cinsiyeti = "Kadın";
                    }
                    else
                    {
                        ekle.Adi = FakeData.NameData.GetMaleFirstName();
                        ekle.Cinsiyeti = "Erkek";
                    }
                    ekle.Soyadi = FakeData.NameData.GetSurname();
                    ekle.Adresi = FakeData.PlaceData.GetAddress();
                    ekle.MailAdresi = FakeData.NetworkData.GetEmail();
                    ekle.Telefonu = FakeData.PhoneNumberData.GetPhoneNumber();
                    ekle.Bolumu = FakeData.TextData.GetAlphabetical(7);
                    ekle.GirisTarihi = FakeData.DateTimeData.GetDatetime(DateTime.Parse("10.10.1995"), DateTime.Now);
                    ekle.Aktifmi = true;
                    double tc= FakeData.NumberData.GetNumber(100000000,2147483647);
                    tc = tc * 10;
                  
                        ekle.PersonelTC = tc.ToString();
                        db.Personeller.Add(ekle);
                        db.SaveChanges();
                   
                  

                }



            }
                
                
                
                
                }

        public List<Personeller> personelListesi()
        {
            return db.Personeller.ToList();
        }

        public bool PersonelEkle(Personeller gelen)
        { 
            try
            {
                Personeller ekle = new Personeller();
                ekle.PersonelTC = gelen.PersonelTC;
                ekle.Adi = gelen.Adi;
                ekle.Soyadi = gelen.Soyadi;
                ekle.Telefonu = gelen.Telefonu;
                db.Personeller.Add(ekle);

                if (db.SaveChanges()>0)
                {
                    return true;
                }
                return false;
                
            }
            catch (Exception e)
            {

                return false;
            }

        
        }

        public List<Personeller> PersonelDetay(int id)
        {
            var sonuc = db.Personeller.Where(f=>f.PersonellerID==id).ToList();
            return sonuc;
        }

        public List<Personeller> PersonelSil(int PID)
        {
                var sonuc = db.Personeller.Where(f => f.PersonellerID == PID).ToList();
                return sonuc;
            
        }

        
        public bool PersonelSil(Personeller gelen)
        {
            try
            {
                
                var silinecek = db.Personeller.Where(f => f.PersonelTC == gelen.PersonelTC).FirstOrDefault();
                db.Personeller.Remove(silinecek);
                if (db.SaveChanges()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
               

            }
            catch (Exception)
            {

               return false;
            }
        }


      


    }
}
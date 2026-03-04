using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance_3
{
    internal class InsanKaynaklari : Personel
    {
        public string DogumTarihi { get; set; }
        public int PersonelSayisi { get; set; }

        public new void Kayit()
        {
            base.Kayit();
            Console.WriteLine("Dogum Tarihi");
            DogumTarihi=Console.ReadLine();
            Console.WriteLine("Personel Sayısı");
            PersonelSayisi=Convert.ToInt32(Console.ReadLine());

        }
        //CRUD Operation (Create oluşturma) (Read/Okuma) (Update/Güncelleme) (Delete/Silme)
        public static void Listele(List<InsanKaynaklari> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine($"Id:{item.Id}\nAd:{item.Ad}\nSoyad{item.Soyad}\nİşe başlama Tarihi:{item.IseGirisTarihi}\nPersonel Sayısı:{item.PersonelSayisi}");

            }
        }

        public static void Sil(List<InsanKaynaklari> liste)
        {
            Listele(liste);
            Console.WriteLine("Silinecek personel yapısı");
            int Id = Convert.ToInt32(Console.ReadLine());
            InsanKaynaklari silinecekPersonel = liste.FirstOrDefault(x => x.Id==Id);
            if (silinecekPersonel==null)
            {
                Console.WriteLine("Girdiğiniz Id de personel bulunamadı");
            }
            else
            {
                bool sonuc = liste.Remove(silinecekPersonel);
                if (sonuc)
                {
                    Console.WriteLine("Personel Silindi");
                }
                else
                {
                    Console.WriteLine("Bir hata oluştu");
                }
            }

        }
        public static void Guncelle(List<InsanKaynaklari> liste)
        {
            Listele(liste);
            Console.WriteLine("Güncellenecek Personel Id si");
            int Id = Convert.ToInt32(Console.ReadLine());
            InsanKaynaklari guncellenecekPersonel = liste.FirstOrDefault(x => x.Id==Id);
            if (guncellenecekPersonel==null)
            {
                Console.WriteLine("Personel bulunamadı");
            }
            else
            {
                guncellenecekPersonel.Kayit();
            }
        }
    }
}

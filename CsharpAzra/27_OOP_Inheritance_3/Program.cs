namespace _27_OOP_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Araba diye bir sınıfımız olacak burası parrent sınıf olacak 
            //İki adet child sınıfı olacak ve bu child sınıfdaki değerler farklı olmalı 
            //Araba sınıfını kullanacaklar fakat kendi özelliklerinide ekrana yazdıracaklar
            //iki sınıfında nesnesi alınacak ve kullanıcı bu değerleri girecek.
            //Ve bu değerler listeye eklenecek sonra her bir değer döngü ile dönderilecek
            //Silme güncelleme yapısıda kullanılsın
            #endregion
            InsanKaynaklari ik = new InsanKaynaklari();
            List<InsanKaynaklari> ikListe = new List<InsanKaynaklari>()
            {
                new InsanKaynaklari(){Id=1,Ad="Erkan",Soyad="Türk",Tc="1234",DogumTarihi="1995",PersonelSayisi=1},
                new InsanKaynaklari(){Id=2,Ad="Azra",Soyad="Şakak",Tc="12345",DogumTarihi="2003",PersonelSayisi=2},
                new InsanKaynaklari(){Id=3,Ad="Onur",Soyad="Yağız",Tc="222",DogumTarihi="2000",PersonelSayisi=3},
                new InsanKaynaklari(){Id=4,Ad="Furkan",Soyad="Uçan",Tc="111",DogumTarihi="2000",PersonelSayisi=4},
                new InsanKaynaklari(){Id=5,Ad="Tahsin",Soyad="Canpolat",Tc="452",DogumTarihi="1992",PersonelSayisi=5},
                new InsanKaynaklari(){Id=6,Ad="Altan",Soyad="Demirci",Tc="3334",DogumTarihi="1995",PersonelSayisi=6},
                new InsanKaynaklari(){Id=7,Ad="Aysu",Soyad="Sarıkaya",Tc="356",DogumTarihi="1995",PersonelSayisi=7},
                new InsanKaynaklari(){Id=8,Ad="Ahmet",Soyad="Akdağ",Tc="55",DogumTarihi="1995",PersonelSayisi=8},
                new InsanKaynaklari(){Id=9,Ad="Veli",Soyad="Demir",Tc="1266634",DogumTarihi="1995",PersonelSayisi=9},
                new InsanKaynaklari(){Id=10,Ad="Erkan",Soyad="Türk",Tc="1234",DogumTarihi="1995",PersonelSayisi=10},

            };
            while (true)
            {
                Console.WriteLine("Lütfen birini seçin:\n1-İk\n2-Bilgi işlem\n3-Muhasebe\n4-Çıkış");
                string secim = Console.ReadLine();
                if (secim =="1")
                {
                    Console.WriteLine("Yapmak istediğiniz işlem\n1-Ekle\n2-Güncelle\n3-Sil\n4-Listele\n5-Çıkış");
                    string islem = Console.ReadLine();
                    if (islem=="1")
                    {
                        
                        ik.Kayit();
                        ikListe.Add(ik);

                    }
                    else if (islem=="2")
                    {
                        InsanKaynaklari.Guncelle(ikListe);
                    }
                    else if (islem=="3")
                    {
                        InsanKaynaklari.Sil(ikListe);
                    }
                    else if (islem=="4")
                    {
                        InsanKaynaklari.Listele(ikListe);
                    }
                    else if (secim=="5")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı seçim");
                    }

                }
            }
        }
    }
}

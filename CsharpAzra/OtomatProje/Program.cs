namespace OtomatProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Otomat Projesi
            /* 

           Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
          Para girişi yapacak. Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, 
              aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

           // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek aynı ürün liste de 
              var ise eklenmeyecek yok ise eklenecek
             Admin şifresi 3 defa yanlış girilince 10 saniye bekletecek hesap kitlenmiştir 
              uyarısı veririp açıldığında bilgilendirecek
           */
            #endregion

            bool admin = false;
            string adminPassword = "a123";
            string kullaniciSifre;
            int yanlisGiris = 0;
            bool kitlendi = false;
            string[] urunler = { "cips", "çikolata", "kola", "su", "soda" };
            double[] fiyatlar = { 60, 50, 90, 25, 35 };
            double bakiye = 0;

            while (true)
            {
                try
                {
                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i} - {urunler[i]}: {fiyatlar[i]}");
                    }
                    Console.WriteLine("Ürün Numarasını Seçiniz (Admin girişi için -1 e basınız.)");
                    int urunNo = Convert.ToInt32(Console.ReadLine());
                    if (urunNo==-1)
                    {
                        Console.Clear();
                        if (!kitlendi)
                        {
                            while (yanlisGiris<3)
                            {
                                Console.WriteLine("Admin Şifrenizi giriniz");
                                kullaniciSifre = Console.ReadLine();
                                if (kullaniciSifre==adminPassword)
                                {
                                    admin = true;
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    yanlisGiris++;
                                    Console.WriteLine($"Hatalı Giriş Yaptınız. Kalan Hakkınız: {3-yanlisGiris}");
                                }
                                if (yanlisGiris==3)
                                {
                                    Console.WriteLine("Yanlış giriş yaptınız Hesabınız 10 saniyeliğine kitlendi ");
                                    kitlendi = true;
                                    Thread.Sleep(10000);
                                    kitlendi = false;
                                    yanlisGiris = 0;
                                   
                                }

                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hesabınız kitlendi Lütfen bekleyiniz");
                            Thread.Sleep(10000);
                            kitlendi = false;
                            

                        }
                        continue;
                    }
                    Console.WriteLine("Para girişi yapınız");
                    bakiye=Convert.ToDouble(Console.ReadLine());
                    if (bakiye>=fiyatlar[urunNo])
                    {
                        Console.WriteLine("Ürünü aldınız. \n Afiyet Olsun. \nPara Üstü: "+(bakiye-fiyatlar[urunNo]));
                        Thread.Sleep(2000);
                        bakiye = 0;
                        Console.Clear();
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Yetersiz Bakiye. Para eklemeniz gerekiyor");
                            Console.WriteLine("Para Ekle 1 \nPara iade 2");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim==1)
                            {
                                Console.WriteLine("Para Ekle");
                                bakiye += Convert.ToDouble(Console.ReadLine());
                                if (bakiye>=fiyatlar[urunNo])
                                {
                                    Console.WriteLine("Ürünü aldınız. \n Afiyet Olsun. \nPara Üstü: "+(bakiye-fiyatlar[urunNo]));
                                    Thread.Sleep(2000);
                                    bakiye = 0;
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (secim==2)
                            {
                                Console.WriteLine("Para iade edildi");
                                Thread.Sleep(2000);
                                bakiye = 0;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama");
                                Thread.Sleep(2000);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Hata: "+ex.Message);
                    Thread.Sleep(2000);
                }
               break;
            }
            if (admin)
            {
                Console.Clear();
                while (true)
                {
                   
                    Console.WriteLine("Admin Paneli");
                    Console.WriteLine("1-Ürün Ekleme\n2-Ürün Güncelleme\n3-Ürün Silme\n4-Ürünleri Listele\n5-Çıkış ");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim==1)
                    {
                        Console.WriteLine("Ürün Adını Giriniz:");
                        string urunAdi = Console.ReadLine().ToLower();
                        bool kontrol = false;
                        for (int i = 0; i<urunler.Length; i++)
                        {
                            if (urunler[i].ToLower()==urunAdi)
                            {
                                kontrol = true;
                                break;
                            }
                        }
                        if (kontrol)
                        {
                            Console.WriteLine("Ürün zaten mevcut");
                            Thread.Sleep(2000);
                            continue;
                        }
                        Console.WriteLine("Ürün Fiyatı:");
                        double fiyat = Convert.ToDouble(Console.ReadLine());
                        Array.Resize(ref urunler, urunler.Length+1);
                        Array.Resize(ref fiyatlar, fiyatlar.Length+1);
                        urunler[urunler.Length-1]=urunAdi;//ürünler dizisinin eleman sayısının
                                                          //1 eksiği index numarasına eşittir
                        fiyatlar[fiyatlar.Length-1]=fiyat;
                        Console.WriteLine("Ürün eklendi.");
                        Thread.Sleep(2000);
                    }
                    else if (secim==2)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} - {urunler[i]}: {fiyatlar[i]}");
                        }
                        Console.WriteLine("Güncellenecek ürün numarası:");
                        int guncelleNo = Convert.ToInt32(Console.ReadLine());
                        if (guncelleNo>=0&&guncelleNo<urunler.Length)
                        {
                            Console.WriteLine("Yeni Ürün Adı: ");
                            string yeniUrun = Console.ReadLine().ToLower();
                            Console.WriteLine("Yeni Fiyat");
                            double yeniFiyat = Convert.ToDouble(Console.ReadLine());
                            urunler[guncelleNo]=yeniUrun;
                            fiyatlar[guncelleNo]=yeniFiyat;
                            Console.WriteLine("Ürün Güncellendi");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                        }


                    }
                    else if (secim==3)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} - {urunler[i]}: {fiyatlar[i]}");
                        }
                        Console.WriteLine("Silinecek urun numarası");
                        int silinecekNo = Convert.ToInt32(Console.ReadLine());
                        if (silinecekNo>=0&&silinecekNo<urunler.Length)
                        {
                            for (int i = silinecekNo; i < urunler.Length-1; i++)
                            {
                                urunler[i]=urunler[i+1];//Yer değiştirme yaparak burada silme işlemi gerçekleştiriyoruz
                                //Örneğin 2. ürünü silmek istiyoruz 2.indexdeki ürünü 3.indexdeki ürünle güncelliyoruz
                                //bu yöntemle tüm ürünleri kaydırarak en sondaki ürünü silmiş oluyoruz
                                fiyatlar[i]=fiyatlar[i+1];
                            }
                            Array.Resize(ref urunler, urunler.Length-1);
                            Array.Resize(ref fiyatlar, fiyatlar.Length-1);
                            Console.WriteLine("Ürün Silindi");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                        }
                    }
                    else if (secim==4)
                    {
                        for (int i = 0; i < urunler.Length; i++)
                        {
                            Console.WriteLine($"{i} - {urunler[i]}: {fiyatlar[i]}");
                        }
                    }
                    else if (secim==5)
                    {
                        Console.WriteLine("İyi günler yine bekleriz ");
                        Thread.Sleep(2000);
                        break;
                    }
                    admin = false;
                }
            }



        }
    }
}

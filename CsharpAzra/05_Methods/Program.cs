namespace _05_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Methodlar(Foksiyonlar)
             * Methodlar yapacağımız bir işi modüler hale getirmemizi sağlar Her method bir iş yapar
             * Bu iş sonucu bir değer döndürebilir veya döndürmeyebilir. Aynı zamanda methodlar
             * parametre alabilir veya almayabilir.
             * Method içinde method tanımlanamaz
             * Methodlar temel olarak 2 ye ayrılır
             * 1. Değer döndüren methodlar(int,double,decimal,bool,char,int[],list,class)
             * 2. Değer döndürmeyen methodlar (void)
             * parametreler methoda verilerek methodun daha dinamik ve parametrik olarak çalışmasonu sağlar.
             * Methodlar sadece çağrıldığı zaman çağırıldığı yerde çalışır.
             * Method isimleri benzersiz olmak zorundadır aynı isime ait methodların imza tipi farklı olmalıdır.
             * imza tipi=> aldığı parametre sayısı, aldığı parametre tipi

             */
            //Yaz();
            //YazParametreli("Test");
            //Console.WriteLine("Yazı Yaz");
            //string metin = Console.ReadLine();
            //YazParametreli(metin);
            //Kullanıcıdan ad soyad yaş değeri alıp bunları ekrana yazdıralım
            //Console.WriteLine("Adınız");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınız");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınz");
            //int yas = int.Parse(Console.ReadLine());
            //Yazdir(ad, soyad, yas);

            //Yazdir2();

            //Kullanıcıdan 4 işlem yapmasını isteyeceğiz toplama çıkarma çarpma bölme
            //fakat bu işlemleri İşlemler adlı bir methodda çağıracağız 
            //Örneğin İşlemler methodunu çağırdım burada ve methoda gitti bana 1.sayı 2.sayıyı sorsun
            //ve yapmak istediğiniz işlem desin toplama ise toplama methoduna yönlendirsin
            //string[] adlar = { "Erkan", "Tahsin", "Onur", "Altan", "Furkan" };

            //DiziYazdir(adlar);
            // DiziYazdir("Ali","Veli","Ahmet"); 3 string parametre olarak algılar dizi olarak algılamaz
            Islem();
            object[] karisikDizi = { "Erkan", 25, 26.5, 'A', true };

            DiziYazdir2(karisikDizi);
        }
        static void DiziYazdir(string[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziYazdir2(object[] dizi)
        {
            foreach (object item in dizi)
            {
                Console.WriteLine(item);
            }
        }


        static void Islem()
        {
            Console.WriteLine("1.Sayı değerini giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayı değerini giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlem (|+|-|*|/|%|)");
            string islem = Console.ReadLine();
            if (islem=="+")
            {
                Topla(sayi, sayi2);
            }
            else if (islem=="-")
            {
                Cikart(sayi, sayi2);
            }
            else if (islem=="*")
            {
                Carp(sayi, sayi2);
            }
            else if (islem=="/")
            {
                Bol(sayi, sayi2);
            }
            else if (islem=="%")
            {
                Mod(sayi, sayi2);
            }
            else
            {
                Console.WriteLine("Hatalı tuşlama");
            }
        }
        static void Topla(double sayi, double sayi2)
        {
            Console.WriteLine(sayi+sayi2);
        }
        static void Cikart(double sayi, double sayi2)
        {
            Console.WriteLine(sayi-sayi2);
        }
        static void Carp(double sayi, double sayi2)
        {
            Console.WriteLine(sayi*sayi2);
        }
        static void Bol(double sayi, double sayi2)
        {
            if (sayi2!=0)
                Console.WriteLine(sayi/sayi2);
            else Console.WriteLine("Hata");
        }
        static void Mod(double sayi, double sayi2)
        {
            double deger = sayi%sayi2;

            Console.WriteLine(deger);
        }
        static void Yazdir(string ad, string soyad, int yas)
        {
            Console.WriteLine($"adınız: {ad} Soyadınız {soyad} Yaşınız {yas}");
        }
        static void Yazdir2()
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınz");
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine($"adınız: {ad} Soyadınız {soyad} Yaşınız {yas}");
        }
        static void Yaz()
        {
            Console.WriteLine("Merhaba");
        }
        static void YazParametreli(string deger)
        {
            Console.WriteLine(deger);
        }

    }
}

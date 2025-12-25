namespace _18_Class_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Erişim belirleyiciler
            /*Access Modifiers (Erişim belirleyici)
             * Private =>Özel yapı bu yapı sadece bulunduğu sınıf içerisinde kullanılabileceği anlamına gelir 
             * diğer sınıflar bu yapıya erişemezlr privete olarak seçilen bir sınıf 
             * sadece kendi içerisinde çağırılır yada kullanılır
             
             *Public=>Hiçbir kısıtlamaya tabi olmayan Solition içerisinde her ayapıdan erişilebieceği anlamına gelir.

             *internal=>bu yapı sadece oluşturulan projedeki yapıların erişebileceği anlamına gelir diğer projeler
             *erişemez kendi projesine özel bir erişim sağlar
             
             *Protected=> inherit(kalıtım) yolu ile erişilir bu yapıya
             *Anasınıf olarak belirtilir ve diğer sınıflar bu yapıdan miras alarak kullanırlar miras alınma yolu ile erişiriz.
             
             *Sealed=>Mühürlü sınıf yapısı bu yapı başka sınıfın miras lamasını engelleyen yapıdır.
             
             */
            #endregion

            #region Static NonStatic
            /* Static nonstatic yapı
             * Static yapılar sınıf içerisinde program çalıştığında çalışan yardımcı yapılar olarak kullanılırlar
             * bir defa çalışır işlemini yapar ve sonrasında daha çalışmazla
             * static sınıflar static yapıları içerisinde barındırır bir sınıf static ise içindeki yapılarda 
             * static olmalıdır
             * Static yapılardan nesneleme(örneklem/instance) işlemleri oluşturulamaz yani new keywordü kullanılmaz
             * 
             * Nonstatic yapılar ise bir değişken üzerinden sınıftaki yapılara erişmek için
             * nesneleme örneklem instance dediğimiz kavramlarla sınıfın özelliklerine erişmemizi sağlarlar.
            */
            //Console.WriteLine();//Static bir yapı kullanıyoruz static sınıfta direkt sınıf üzerinden değer oluşturulur
            //Random random = new Random();//nonstatic yapıdır 
            #endregion

            #region Class Access Modifiers Örnek
            //Ogretmen ogretmen = new Ogretmen();
            //ogretmen.OgretmenName="Erkan";
            //ogretmen.OgretmenSurName="Türk";
            //ogretmen.Phone=533333333;
            //ogretmen.OgretmenTest();

            //Ogretmen ogretmen1 = new Ogretmen();
            //ogretmen1.OgretmenTest();

            ////Ogrenci ogrenci = new Ogrenci();
            ////ogrenci.OgrenciAdi;// bulunduğu sınıf içerisinde private olarak işaretlendiği için başka
            ////sınıfların kullanması engellidir.
            #endregion

            #region Record kullanımı
            //Console.WriteLine("Record kullanımı");
            ////record tek satırda nesne oluşturma (positional record)
            //Personel personel = new("Erkan", "Türk", 31);
            //Personel personel1 = new Personel("Azra", "Şakak", 19);

            //Console.WriteLine($"{personel1.Ad} {personel1.Soyad} {personel1.yas}");
            ////with ifadesi:kopyalayarak değiltirme (immutable)

            //Personel personel2 = personel with { yas=35 };

            //Console.WriteLine($"{personel2.Ad} {personel2.Soyad} {personel2.yas}");

            //Console.WriteLine("Ad");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyad");
            //string soyad= Console.ReadLine();
            //Musteri musteri = new Musteri()
            //{
            //    MusteriAd=ad,//Kullanacağın propertyleri zorunlu kılıyor.
            //    MusteriSoyad=soyad,
            //    Adres="İstanbul"//Opsiyonel doldurmak zorulu değil
            //};
            ////Musteri musteri1 = new Musteri(); hata verir
            ////musteri1.MusteriAd="Erkan";
            ////musteri1.MusteriSoyad="Türk";


            //Console.WriteLine(musteri.MusteriAd+" "+musteri.MusteriSoyad+" "+musteri.Adres);
            #endregion
            #region Struck
            //Dikdortgen dikdortgen = new Dikdortgen() { Genislik=10, Yukseklik=5 };
            //Console.WriteLine($"Dikdörtgen: {dikdortgen.Genislik}x{dikdortgen.Yukseklik}");
            //Console.WriteLine($"Alan: {dikdortgen.AlanHesapla()}");
            #endregion
            #region NullCheck
            //NullKontrolOrnekleri.KontrolYap("");
            string? deger = null;
            NullKontrolOrnekleri.KontrolYap(deger);
            string metin = "Bugün hava yağışlı";
          
            NullKontrolOrnekleri.KontrolYap(metin);
            #endregion
        }
    }
}

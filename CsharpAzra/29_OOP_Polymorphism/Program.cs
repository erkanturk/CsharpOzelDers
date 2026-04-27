using System.Threading.Channels;

namespace _29_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism(Çok biçimcilik)
            /*
         POLYMORPHISM NEDİR? 

         Çokbiçimlilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği 
        anlamına gelir ve statik, dinamik olmak üzere ikiye ayrılır.

            * Statik çokbiçimlilik; metot ve operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
            * Dinamik çokbiçimlilik; özet sınıflardan miras alma yoluyla işlemlerin gerçekleştirilmesi 
            * işlemine verilen isimdir.

        Statik çokbiçimlilik türünden, metotların aşırı yüklenmesine yönelik bir çalışma yapacağız.

        Dinamik çokbiçimlilik türünden, metodu override etmeliyiz.

        VIRTUAL() METODU

        *Temel sınıfa ait bir metodun bazen türemiş sınıfta farklı bir şekilde kullanılması gerekebilir.
        *Bu durumda temel sınıfın söz konusu metodu türemiş sınıfın değiştirip kullanabileceği 
        *yönünde izin vermesi gerekir. Bu izin, metodun temel sınıfta “virtual” olarak tanımlanması 
        *sonucu verilmektedir. Diğer bir ifadeyle temel sınıfta “virtual” olarak tanımlanmış bir metodun
        *türemiş sınıfta yeniden yazılabileceği belirtilmiş olunuyor.


        METODU OVERRIDE ETMEK, OVERRIDE NEDİR?METOTUN EZİLMESİ

        *Temel sınıfta “virtual” tanımlanmış bir metodun türemiş sınıfta yeniden 
        *yazılması için (geçersiz kılma) “override” sözcüğü kullanılır. 
         *Temel sınıfta “virtual” tanımlanmamış ya da “static” tanımlanmış olan 
         *üyeler (metot, özellik, dizinleyici ya da olay) türemiş sınıfta yeniden yazılamaz (Geçersiz kılınamaz.).

        Ayrıca temel sınıfta “virtual”, “abstract” ya da “override” olarak tanımlanmış
        metotlar türemiş sınıfta geçersiz kılınabilir.
        Bir diğer önemli nokta da “override” metotlar “new”, “static” ya da “virtual”
        sözcükleri ile tanımlanamaz.

        Son olarak “virtual” metodun erişim belirteci “override” sırasında değiştirilemez.
        Yani temel sınıfta metot “public” ise türemiş sınıfta da “public”, “protected” ise “protected” kalmalıdır.
        */

            #endregion

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Kaydet();
            ogrenci.NotAl(100, 100);
            ogrenci.NotAl();
            Console.WriteLine($"Ad {ogrenci.Ad} Soyad {ogrenci.Soyad} OgrNo {ogrenci.OgrNo} Vize {ogrenci.Vize} Final {ogrenci.Final}");

            LiseOgrenci liseOgrenci = new LiseOgrenci();
            liseOgrenci.Kaydet();

        }
    }
    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public virtual void Kaydet()
        {
            Console.WriteLine("Ad");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            Soyad = Console.ReadLine();
            Console.WriteLine("Yaş");
            Yas = Convert.ToInt32(Console.ReadLine());

        }
    }
    class Ogretmen : Insan
    {
        public string Brans { get; set; }

        public override void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Branş");
            Brans = Console.ReadLine();
        }

    }
    class Ogrenci:Insan
    {
        public int OgrNo { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        public void NotAl()
        {
            Console.WriteLine("Vize:");
            Vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final:");
            Final = Convert.ToInt32(Console.ReadLine());

        }
        public void NotAl(int vize, int final)
        {
            Vize = vize;
            Final = final;
        }
        public override void Kaydet()
        {
            base.Kaydet();
            Console.WriteLine("Öğrenci Numarası");
            OgrNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vize");
            Vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final");
            Final = Convert.ToInt32(Console.ReadLine());

            
        }

    }
    class LiseOgrenci:Ogrenci
    {
        public string Brans { get; set; }
        public int SinavNotu { get; set; }
        public int SinavNotu2 { get; set; }
        public int SinavNotu3 { get; set; }

        public override void Kaydet()
        {
            Console.WriteLine("Ad");
            Ad = Console.ReadLine();
            Console.WriteLine("Branş");
            Brans = Console.ReadLine();
            Console.WriteLine("1.Sınav");
            SinavNotu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sınav");
            SinavNotu2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Sınav");
            SinavNotu3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Braş {Brans} 1.Sınav {SinavNotu} 2.Sınav {SinavNotu2} 3.Sınav {SinavNotu3}");
        }
    }
}

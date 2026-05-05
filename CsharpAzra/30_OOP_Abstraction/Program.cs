using System.Threading.Channels;

namespace _30_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Abstract nedir ?(Soyutlama)
             * Abstract class'lar oluşturulması istenen class'ların sadece base class olarak davranması
             * ve üzerinde bir instance(örneklem/nesne oluşturma/new()) oluşturulmamasını istediğimiz durumlarda kullanılır
             * C# da bu donksiyoneliteyi sağlamak için abstract keywordu kullanımı yeterlidir.
             * Abstract sınıflar içerisinde gövdesiz methodlar tanımlayabiliriz
             * bu methodlar miras alınan sınıf içerisinde mutlaka gövdeleri doldurulmalıdır
             * Abstract sınıflar alt sınıflara abstract olmayan yapıları kullanmaya zorlarlar.
             * Bu işleme biz implemente deriz.
             * Abstrac olarak işaretlenen yapılar override edilebilir 
             * Sadece methodlar değil propertyler de abstract olarak işaretlenebilirler.

             */
            //HATAAAAAA
            //Insan insan=new Insan();//Soyut yapı nesnesi oluşturulamaz.
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Create();
            ogrenci.Update();
            ogrenci.Delete();
        }
    }
    public abstract class Insan//Abstract keywordu varsa bir methodda veya property de mutlaka alt sınıf bu yapıyı implemente 
        //etmek zorundadır yani eğer insansan tc kimlik numaran var bunu doldurmak zorundasın diye kanıt bekliyoruz.
    {
        public abstract long Tc { get; set; }
        public string Ad {  get; set; }
        public string Soyad { get; set; }

        public abstract void Create();//Gövdesiz method
        public abstract void Update();
        public abstract void Delete();
        public abstract void List();

        public void Find(int id)
        {
            Console.WriteLine(id);//Gövdeli method
            //gövdeli methodda sınıf içerisinde bu metodun yapacağı işlemi belirtiriz fakat gövdesiz methodda 
            //Miras alan sınıf bu gövdeleri kendisi belirtmelidir
            
           


        }

    }
    public class Ogrenci : Insan
    {
        public override long Tc { get; set; }
        public string DerslikSayisi { get; set; }
        public string Bolum { get; set; }

        public override void Create()
        {
            Console.WriteLine("TC");
            Tc = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Bolum");
            Bolum = Console.ReadLine();
            Console.WriteLine("Derslik sayısı");
            DerslikSayisi = Console.ReadLine();
            Console.WriteLine("Ad");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad");
            Soyad = Console.ReadLine();
            List();
        }

        public override void Delete()
        {
            Tc = 0;
            Bolum = null;
            DerslikSayisi = null;
            Ad = null;
            Soyad = null;
            List();
        }

        public override void List()
        {
            Console.WriteLine(Tc + " " + Ad + " " + Soyad + " " + Bolum + " " + DerslikSayisi);
        }

        public override void Update()
        {
            Create();
        }
    }
    public class Mudur : Insan
    {
        public string Ders {  get; set; }
        public string SicilNo { get; set; }

        public override long Tc { get ; set; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void List()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}

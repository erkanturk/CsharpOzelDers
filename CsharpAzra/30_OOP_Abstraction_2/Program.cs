using System.Threading.Channels;

namespace _30_OOP_Abstraction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Abstract sınıflar birbirinden miras alırlar ve bu yapılar birbirlerini implemente etmek zorunda değiller*/
            BuzDolabi buzDolabi = new BuzDolabi();
            buzDolabi.AlisFiyati = 10000;
            buzDolabi.KarYuzdesi = 2.20;
            buzDolabi.Yazdir();
        }
    }
    public abstract class Elektronik
    {
        protected Elektronik()
        {
            Console.WriteLine("Elektronik");
        }
        public double AlisFiyati {  get; set; }
        public double KarYuzdesi { get; set; }
        public abstract double FiyatHesapla();
    
    }
    public abstract class Sarjli : Elektronik
    {
        public abstract double Mah {  get; set; }
    }
    public abstract class Elektrikli : Elektronik
    {
        protected Elektrikli()
        {
            Console.WriteLine("Elektirikli");
        }
        public abstract int Volt { get; set; }
    }
    public class Telefon : Sarjli
    {
        public override double Mah { get; set; } = 5000;

        public override double FiyatHesapla()
        {
            return AlisFiyati * KarYuzdesi;
        }
    }
    public class BuzDolabi : Elektrikli
    {
        public BuzDolabi()
        {
            Console.WriteLine("Buzdolabı");
        }
        public override int Volt { get; set; } = 240;

        public override double FiyatHesapla()
        {
            return AlisFiyati * KarYuzdesi;
        }
        public void Yazdir()
        {
            Console.WriteLine($"Voltaj{Volt} Fiyat {FiyatHesapla()}");
        }
    }
    public class Laptop : Elektrikli//,Sarjli //Class yapısı mutable inheritance yapısını desteklemez
        //Aslında bu durum programlama dillerinde diamond problem olarak adlandırılır
    {
        public override int Volt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double FiyatHesapla()
        {
            throw new NotImplementedException();
        }
    }
}

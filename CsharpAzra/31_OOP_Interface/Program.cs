namespace _31_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* InterFace(Arayüz)
             * Bir arayüzdür sınıf değildir
             * Gövdesiz methodlar tanımlanır (Sözleşme/Kontrat)
             * .Net 8+ ile gövdeli methodlar da yanımlanabilir (default implementation)
             * Yapıcı method yani constructor tanımlanamaz
             * Instance (new()) oluşturulamaz
             * Bir sınıf bir class miras alabilir fakat birden fazla interface implemente edebilir.
             * Interface isimleri genelde 'I' ile başlar (IList IEnumarable ICollection vb. gibi)
             * 
             * Neden kullanılır ?
             * Büyük projelerde geliştiricilere yol gösterir
             * Sınıfların hangi özellikleri barındırması gerektiğini belirtir.
             * Loose coupling (gevşek bağlılık) sağlar
             * Test edilebilirliği arttırır
             * Mutable inheritance yapısını sağlar ve diamond problemi ortadan kaldırır.
             */
            Arac arac = new Arac();
            Console.WriteLine($"Marka:{arac.Marka} Model:{arac.Model} Batarya:{arac.Batarya} Kapasite:{arac.Kapasite}");
            arac.Calistir();
            arac.Durdur();
            arac.SartEt();
        }
    }
    public abstract class Tasit//:IArac//Bir sınıf bir interface'den miras alırken bir interface bu işlemi gerçekleştiremez.
    {
        public abstract int Kapasite { get; set; } 
    }

    public interface IArac//:Tasit hata verir
    {
        string Marka {  get; set; }
        string Model { get; set; }
        void Calistir();
        void Durdur();
    }
    public interface ISarjEdilebilir : IArac//interface interface e uygulanabilir ve özelliklerini zorunlu olarak kullanmak zorunda değildir. implemente almasına gerek yoktur.
    {
        int Batarya { get; set; }
        void SartEt();
    }
    public class Arac :Tasit,ISarjEdilebilir
    {
        public int Batarya { get; set; } = 45000;
        public string Marka { get; set; } = "Togg";
        public string Model { get; set; } = "T10X";
        public override int Kapasite { get; set; } = 4;

        public void Calistir()
        {
            Console.WriteLine("Araç çalıştı");
        }

        public void Durdur()
        {
            Console.WriteLine("Araç durdu");
        }

        public void SartEt()
        {
            Console.WriteLine("Araç şart ediliyor");
        }
    }
}

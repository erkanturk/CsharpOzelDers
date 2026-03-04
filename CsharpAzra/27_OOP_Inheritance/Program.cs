namespace _27_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Inheritance (Kalıtım/Miras alma)
             * Bir sınıf ortak özellikleri barındırır.(base/parent class)
             * Alt sınıflar (child class) bu sınıftan miras alır (:)
             * Alt sınıflar base class'ın özelliklerini kullanabilir.
             * base class alt sınıftan miras alamaz.

             */
            Telefon telefon = new Telefon();
            telefon.CPU="A18";
            telefon.Ram="8";
            telefon.Mah=5200;
            telefon.Inc=10;
            telefon.SarjGirisi="Type C";
            telefon.Yaz();

            Laptop laptop = new Laptop();
            laptop.CPU="i7h255x";
            laptop.Ram="DDR5 16gb";
            laptop.Mah=10000;
            laptop.Inc=16;
            laptop.EkranKarti="Nvidia RTX5090";
            laptop.Yaz();


        }
    }
}

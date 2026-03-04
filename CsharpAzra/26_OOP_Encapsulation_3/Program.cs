namespace _26_OOP_Encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            Console.WriteLine("Iban giriniz");
            string Iban = Console.ReadLine();

            Console.WriteLine("Ad");
            string ad = Console.ReadLine();
            Console.WriteLine("Yaş");
            int yas = Convert.ToInt32(Console.ReadLine());
            ogrenci.IbanAl(Iban);
            ogrenci._Ad=ad;
            ogrenci._Yas=yas;

            Console.WriteLine($"Adınız {ogrenci._Ad} Yaşınız: {ogrenci._Yas}");
        }
    }
}

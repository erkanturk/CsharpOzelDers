namespace _12_Ref_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            /* Ref-methods bu yapıda referans olarak gösterdiğimiz bir değeri güncelleme yapmamızı sağlar dışarıda bir değer olması mutlaka zorunludur.
            Örneğin:Ben bakkaldan bir çikolata aldım fakat bakkal bu çikolatayı toptancıdan 10 tl ye aldı bana satarken
            fiyat 15 tl olarak güncellendi bu yapıda ref mantığı ile çalışmalıdır.

            Ref ile birden fazla değeri dışarı çıkarabiliriz
            Return bir değer dışarı çıkarırken Ref ve Out keywordleri birden fazla değer çıkarmamızı sağlar.

            */

            int sayi = 10;
            int sayi2 = 20;
            int sayi3 = 30;

            Refli(ref sayi, ref sayi2, ref sayi3);
            Console.WriteLine(sayi3);
            Console.WriteLine(sayi2);
            Console.WriteLine(sayi);


        }
        static void Refli(ref int sayi,ref int sayi2,ref int sayi3)
        {
            sayi *= 2;
            sayi2 *= 3;
            sayi3 *= 4;
        }
    }
}

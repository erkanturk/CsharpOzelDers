namespace _01_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı bu diziyi doldursun dolan dizideki her bir elemanın çift sayı ve tek sayılarını toplayıp
            //tek toplam çift toplam olarak ekrana yazdıralım.

            // //kullanıcının girdiği kelimeyi karakterlere ayırıp gösteren bir dizi yapısı yapalım.
            Console.WriteLine("Değer giriniz");
            string deger = Console.ReadLine();
            for (int i = 0; i < deger.Length; i++)
            {
                Console.WriteLine(deger[i]);
            }
        }
    }
}

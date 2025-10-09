namespace _01_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı bu diziyi doldursun dolan dizideki her bir elemanın çift sayı ve tek sayılarını toplayıp
            //tek toplam çift toplam olarak ekrana yazdıralım.

            // //kullanıcının girdiği kelimeyi karakterlere ayırıp gösteren bir dizi yapısı yapalım.
            //Console.WriteLine("Değer giriniz");
            //string deger = Console.ReadLine();
            //for (int i = 0; i < deger.Length; i++)
            //{
            //    Console.WriteLine(deger[i]);
            //}

            #region Örnek
            //Kullanıcıya Kaç adet Personeli olduğunu soralım ve örneğin 5 personel dedi herbirini diziye atalım 
            //5 personeli mevcut personelleriniz diye gösterelim
            Console.WriteLine("Kaç personeliniz var");
            string[] personeller = new string[int.Parse(Console.ReadLine())];
            for (int i = 0; i < personeller.Length; i++)
            {
                Console.WriteLine($"{i+1}.Personel ismi giriniz");
                personeller[i] = Console.ReadLine();
            }
            foreach (string personel in personeller)
            {
                Console.WriteLine(personel);
            }
            #endregion
        }
    }
}

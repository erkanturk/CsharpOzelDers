namespace _13_Recursive_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Recursive Method
             * Bir işin tamamını yapmak yerine parçalı bir halde tamamlayan bir yapıdır
             * Bu yapı methodun belli bir koşul içerisinde tekrar kendi içerisinde tanımlanması sonucunda oluşan bir işlemdir
             * Bu işleme Yineleyen Method diyoruz
             
             */
            //Yaz();//Sonsuz tekrar eder
            Console.WriteLine("Çoklu form için 1 e tekli form için 2 ye basınız");
            int sayi=Convert.ToInt32(Console.ReadLine());
            if(sayi==1)
            {
                Console.WriteLine("Kaç Adet Olsun");
                int sayi2=Convert.ToInt32(Console.ReadLine());
                CokluForm(sayi2);
            }
            else
            {
                TekliForm();
            }
        }
        static void Yaz()
        {
            Console.WriteLine("MErhaba");
            Yaz();
        }
        static void TekliForm()
        {
            string ad = "";
            string soyad = "";
            string yas = "";
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Adınız");
            //     ad = Console.ReadLine();
            //    Console.WriteLine("Soyadınız");
            //     soyad = Console.ReadLine();
            //    Console.WriteLine("Yaşınız");
            //     yas = Console.ReadLine();
            //}
            Console.WriteLine("Adınız");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            yas = Console.ReadLine();

            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yas: {yas}");
        }
        static void CokluForm(int sayi)
        {
            Console.WriteLine("Adınız");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız");
            string yas = Console.ReadLine();

            if(sayi>0)
            {
                CokluForm(sayi - 1);
            }

            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yas: {yas}");
        }
    }
}

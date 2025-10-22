namespace _09_Params_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Params Method 
             * Params keywordu methodun zorunlu parametresinden sonra verilmelidir 
             * Paramsın özelliği sınırsız sayıda aynı veritipine ait değerler göndermemizi sağlar
             * Params olarak işaretlenmiş bir değer sadece verildiği veri tipinde sınırsız sayıda değer alabilir yada almayabilir.
             
             */

            //Yaz(10,20,30);İki parametreli methoda 2 parametre göndermek zorunludur
            //Yaz2(20);//Params parametresine değer göndermeden sadece zorunlu parametreye değer verdik
            //Yaz3(20,20,30,40,50,60,70,80,90);//Sınırsız değer alabilir 
            int[] sayilar = { 1, 2, 3, 4, 5, 6, };
            //DiziAl(sayilar);
            //DiziAl(10, 20, 30, 40, 50);//Method benden dizi istiyor ben sayı parametreleri gönderiyorum
            //Paramsli(sayilar);//Sayı olan bir yapıyı da barındırabilir
            //Paramsli(10, 20, 30, 40, 50);//yada birden fazla sayıları da alabilir
            //Kullanıcıdan Sayılar alalım bu sayıları Paramslı methoda yollayalım sonrasında
            //Bu sayılara %20 kdv uygulayıp Tekrardan dışarı çıkaralım
            //double[] fiyatlar = new double[10];

            //for (int i = 0; i < fiyatlar.Length; i++)
            //{

            //    Console.WriteLine($"{i+1}. Fiyat");
            //    fiyatlar[i]=Convert.ToDouble(Console.ReadLine());

            //}
            //Console.WriteLine("*******************");
            //foreach (double item in KdvUygula(fiyatlar))
            //{
            //    Console.WriteLine(item);
            //}
           // Nesne("String",'A',true,false,DateTime.Now,10,15.5,12.2f,13.5m, sayilar[0]);
        }
        static void Yaz(int sayi,int sayi2)
        {
            Console.WriteLine(sayi);
            Console.WriteLine(sayi2);
        }
        static void Yaz2(int sayi, params int[] paramsli)
        {
            Console.WriteLine(sayi);
            foreach (var item in paramsli)
            {
                Console.WriteLine(item);
            }
        }
        static void Yaz3(params int[] paramsli)
        {
           
            foreach (var item in paramsli)
            {
                Console.WriteLine(item);
            }
        }
        static void DiziAl(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void Paramsli(params int[] sayilar)
        {
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }
        //Kullanıcıdan alınan ilk 3 ürüne %50 4 6. ürüne %30 geri kalanlara %10 kdv uygulanacak
        static double[] KdvUygula(params double[] fiyatlar)
        {
            for (int i = 0; i < fiyatlar.Length; i++)
            {
               if(i<=2)
                {
                    fiyatlar[i] *= 1.50;
                }
               else if(3<=i&&i<6)
               {
                    fiyatlar[i] *= 1.30;
               }
               else
               {
                    fiyatlar[i] *= 1.10;
                }
            }
            return fiyatlar;
        }

        static void Nesne(params object[] objects)
        {
            foreach (object item in objects)
            {
                Console.WriteLine(item);
            }
        }
    }
}

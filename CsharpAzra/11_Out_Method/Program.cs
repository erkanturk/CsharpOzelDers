namespace _11_Out_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Out keyword
               Bir method parametresi out ile işaretlenmiş ise bu yapı dışarıya çıkış olarak belirtilmiştir
           bu yapı dışarıda null olabilir null bir değere atama yapılabilir
           Reften farklı olarak outda null değerlerle işlem yaparken Ref de ise bir değeri referans almalıyız.
           Gerçek hayattaki örneği şudur
           Ben bir işe başlayacağım fakat benim referansım yok yani yeni mezunum 
           bir işe başladım sonrasında artık o yer benim referansım oldu 
           Null bir değer artık null olmaktan çıktı son aldığı değeri göstermeye başladı.
           */
            //double sayi, sayi2, sayi3;
            ////Console.WriteLine(sayi);//null değer hata verir
            //Sayilar(out sayi, out sayi2, out sayi3);
            //Console.WriteLine(sayi);
            //Console.WriteLine(sayi2);
            //Console.WriteLine(sayi3);
            string metin;
            int s ;
            int s2;
            Metinler(out metin);
            Console.WriteLine(metin);
            Console.WriteLine(Sayilar3(out s, out s2));
            Console.WriteLine(s);
            Console.WriteLine(s2);
        }
        static void Sayilar(out double s , out double s2, out double s3)
        {
            s = 15;
            s2 = 25;
            s3 = 26;

        }
        static void Metinler(out string deger)
        {
            deger = "Merhaba";
        }
        static int Sayilar3(out int sayi , out int sayi2)
        {
            sayi = 30;
            sayi2 = 20;

            return sayi + sayi2;
        }
    }
}

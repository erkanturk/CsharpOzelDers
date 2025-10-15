namespace _06_Return_Methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan fiyat alalım ve kdv oranı soralım 
            //girdiği fiyata kdv uyfulayan methodu yazalım 
            //Hem parametreli hem parametresiz yapalım 
            //Hemde returnlü olsun
            //Kdv();
            //Console.WriteLine("Ürün fiyatı girin");
            //double fiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Kdv Oranı");
            //double kdv = Convert.ToDouble(Console.ReadLine());
            //Kdv2(fiyat, kdv);
            //Console.WriteLine(Kdv3());
            //Console.WriteLine(Kdv4(fiyat, kdv));

            //Console.WriteLine(kdv*=Kdv5());

            //Kullanıcıdan bir değer girmesini isteyelim bu değeri bir methoda yollayalım kullanıcının girdiği değerin uzunluğunu int olarak ekranda döndüreli
            //Örneğin Kullanıcı JavaScript yazdı geriye girilen metnin uzunluğu 10 değeri dönecek
            //Console.WriteLine("Değer Giriniz");
            //Console.WriteLine(AdUzunluk(Console.ReadLine()));
            //Geriye dizi döndüren method yapısı
            //Yaşlar diye bir dizi olacak bu dizinin elemanlarını geriye döndüren method yapısı olacak dizi methodun içinde tanımlanacak ve bu diziyi geriye döndürecek bu method dışarıda her bir yaşı yazdıracak
            //foreach (int item in Yaslar())
            //{
            //    Console.WriteLine(item);
            //}
            //Kullanıcıdan bir diziye eleman girmesini isteyelim girdiği diziyi döndürelim
            //kullanıcının değerleri girdiği diziyi bir methoda gönderelim ve her bir elemana 1.10
            //fiyat artışı ekleyip geriye güncellenmiş fiyatları döndürelim
            Console.WriteLine("Kaç ürün aldınız");
            int urunSayisi = Convert.ToInt32(Console.ReadLine());
            double[] urunler=new double[urunSayisi];

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i+1}.Ürün fiyatını giriniz");
                urunler[i]=Convert.ToInt32(Console.ReadLine());

            }

            foreach (double item in KdvUygula(urunler))
            {
                Console.WriteLine(item);
            }


        }
        static double[] KdvUygula(double[] dizi)
        {
            double[] yeniFiyat=new double[dizi.Length];
            int index = 0;
            foreach (double i in dizi)
            {
                yeniFiyat[index] = i * 1.10;
                index++;
            }
            return yeniFiyat;

        }
        static int[] Yaslar()
        {
            int[] yaslar = { 20, 30, 40, 50, 60 };
            return yaslar;
        }
        static int AdUzunluk(string ad)
        {
            int uzunluk = ad.Length;
            return uzunluk;
        }
        static void Kdv()
        {
            Console.WriteLine("Ürün fiyatı girin");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv Oranı");
            double kdv = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Parametresiz iş yapan "+(fiyat*=kdv));
            
            
        }
        static void Kdv2(double fiyat, double kdv)
        {


            Console.WriteLine("parametreli iş yapan "+(fiyat*=kdv));
        }
        static double Kdv3()
        {
            Console.WriteLine("Ürün fiyatı girin");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv Oranı");
            double kdv = Convert.ToDouble(Console.ReadLine());
            return (fiyat*=kdv);
        }

        static double Kdv4(double fiyat, double kdv)
        {

            return (fiyat*=kdv);
        }
        static double Kdv5()
        {
            Console.WriteLine("Ürün fiyatı girin");
            double fiyat = Convert.ToDouble(Console.ReadLine());
         
            return (fiyat);
        }
    }
}

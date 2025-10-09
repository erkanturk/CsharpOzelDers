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
            Kdv();
            Console.WriteLine("Ürün fiyatı girin");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kdv Oranı");
            double kdv = Convert.ToDouble(Console.ReadLine());
            Kdv2(fiyat, kdv);
            Console.WriteLine(Kdv3());
            Console.WriteLine(Kdv4(fiyat, kdv));
            
            Console.WriteLine(kdv*=Kdv5());
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

namespace _08_OverLoad_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*OverLoad Methods 
            İmza tipleri farklı isimleri aynı olurlar 
            Aynı imza tipini barındıramazlar
            Hangi veri tipi kullanılacak ise o overload method devreye girer.
            İmza tipleri int,double ,decimal ,bool,ArrayList string Class int[] v.b. yapılar imza
            tipi olarak adlandırılır bu yapılar benzersiz olmalıdır.
            OverLoad Yapı aslında OOP Dediğimiz Object Oriented Programing Tarafındaki Polymorphism i destekler
            Yani Statik çok biçimciliğe bir örnektir.
             */
            /* Summary Methods Summary yapısı developerların bilgilendirme için 
            methodlara verdiği açıklama yapılarıdır.
            
            */
            //Console.WriteLine();//Toplam 18 aşırı yüklemesi mevcut bir overload methoddur
            //Console.WriteLine("Merhaba");
            //Console.WriteLine(true);
            //Console.WriteLine(10);
            //Console.WriteLine(10.5);
            //Console.WriteLine(10.5+25);
            Yaz();
            Yaz("OverLoad");
            Yaz("Girilen Sayı: ",20);
            Yaz("Girilen Sayı Çarpımı: ", 20,30.5);
            Yaz("Girilen Sayı Toplamı: ", 20,30);
            Yaz("Girilen Sayı Toplamı: ", 20.5);
        }
        static void Yaz()
        {
            Console.WriteLine("Merhaba");
        }
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Yaz(string metin,int sayi)
        {
            Console.WriteLine(metin+" "+sayi);
        }
        static void Yaz(string metin, double sayi)
        {
            Console.WriteLine(metin + " " + sayi);
        }
        static void Yaz(string metin, double sayi,int sayi2)
        {
            Console.WriteLine(metin + " " + (sayi+sayi2));
        }
        static void Yaz(string metin, double sayi,double sayi2)
        {
            Console.WriteLine(metin + " " + (sayi*sayi2));
        }
    }
}

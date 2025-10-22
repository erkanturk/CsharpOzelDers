namespace _10_OptionalParameters_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Optional Parameters bir methoda parametre vermeden de kullanılabilir bu yapı isteğe bağlı parametre yapısı ile belirtilmelidir bu yapının kendi içerisinde bir değer olur ve bu değer eğer parametre verilmezse varsayılan değer olarak
           gelir bu değer eğer verilirse gelen değer kalıcı değer olarak ayarlanır.
           opsiyonel yapı methodun son değerleri olmak zorundadır bu yapıdan sonra normal parametre tanımlaması yapılamaz.

           */
            Yaz("test");
            Console.WriteLine("Ad");
            string adiniz=Console.ReadLine();
            Console.WriteLine("Soyad");
            string soyadiniz=Console.ReadLine();
            Console.WriteLine("Yaş");
            int yasiniz = Convert.ToInt32(Console.ReadLine());

            //Optional(adiniz,soyadiniz,yasiniz);//Ülke değeri varsayılan methodda atanılan değer olarak gelecek.
            //Optional(adiniz, soyadiniz, yasiniz, "Amerika");
            //Insan(adiniz,soyadiniz,yasiniz,"İngiltere");
            //Insan(ad:adiniz,soyad:soyadiniz,yas:yasiniz,meslek:"Yazılım");//Methoddaki parametreleri kullanarak hangi alanları kullanmak istediğimizi belirtiriz.
        }
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Optional(string ad, string soyad ,int yas,string ulke="Türkiye" )
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas} Ülke: {ulke}");
        }
        static void Insan(string ad, string soyad, int yas, string ulke = "Türkiye",string meslek="Serbest Meslek",string sehir="İstanbul")
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas} Ülke: {ulke} Meslek: {meslek} Şehir: {sehir}");
        }
    }
}

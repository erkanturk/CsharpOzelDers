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
            Insan(ad:adiniz,soyad:soyadiniz,yas:yasiniz,meslek:"Yazılım");//Methoddaki parametreleri kullanarak hangi alanları kullanmak istediğimizi belirtiriz.
            Yaz("test");
        }
        /// <summary>
        /// <see href="https://www.google.com.tr"/>
        /// </summary>
        /// <param name="metin"></param>
        static void Yaz(string metin)
        {
            Console.WriteLine(metin);
        }
        static void Optional(string ad, string soyad ,int yas,string ulke="Türkiye" )
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas} Ülke: {ulke}");
        }
        /// <summary>
        /// Opsiyonel olarak Ad Soyad Yaş değerlerinden sonra Ülke ve meslek şehir kısımlarını bize 
        /// method tarafındanda gelebilir opsiyonel olarak doldurulması zorunlu değildir.
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="soyad"></param>
        /// <param name="yas"></param>
        /// <param name="ulke"></param>
        /// <param name="meslek"></param>
        /// <param name="sehir"></param>
        static void Insan(string ad, string soyad, int yas, string ulke = "Türkiye",string meslek="Serbest Meslek",string sehir="İstanbul")
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaş: {yas} Ülke: {ulke} Meslek: {meslek} Şehir: {sehir}");
        }
    }
}

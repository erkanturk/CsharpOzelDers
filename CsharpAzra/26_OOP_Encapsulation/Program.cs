namespace _26_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*OOP
             * Object oriented programming - Nesne yönelimli programlama
             * İlk yazılım sıralı satırlı olarak geliştiriliyordu
             * Sonrasında Class(sınıf) yapısı üzerinden geliştirilmeye başlandı ama hala büyük çaplı projeler yazılmıyordu.
             * C dili => OOP geliştirilmesi ile C++ dili ortaya çıktı
             * C++ gün geçtikçe popüleritesini kaybeden ama önceki yıllarda yazılmış
             * projeler üzerinde  hala geliştirilen çok güçlü bir dildir. Makine proramlama siber güvenlik,
             * otomobil beyni,vb işlerde kullanılır.
             * İnternetin icadıyla birlikte Java ve C# dilleri ortaya çıkmıştır.
             * 
             * OPP 4 Temel ilkesi vardır.
             * 1-Encapsulation-Kapsülleme
             * 2-Inheritance-Kalıtım(Miras alma)
             * 3-Polymorphism-Çok biçimcilik
             * 4-Abstraction-Soyutlama
             */
            /*Encapsulation
             * Bir nesnenin propertylerinde doğruluk kontrolü yapılması gerektiğinde kullanılan bir oop yapısıdır.
             * Propertyler private olarak tanımlanır ve dışarıdan direkt kullanıma kapalıdır.
             * Aynı property'in benzer isimde public olarak br tanımlaması yapılır ve kullanıcıdan bu 
             * propertiye data girişi yapılması istenir
             * girilen data set keyword ile kontrol edilerek asıl propertye aktarılır.
             * Get kısmı ise property içindeki değeri okumak ve getirmek için kullanılır.

             */
            #region Ödev Kapsülleme
            /*** Ödev ***
        Bir banka hesabını temsil eden bir uygulama geliştirmek istiyoruz. 
        Bu uygulamada, hesap bakiyesi gizli tutulmalı ve sadece belirli
        işlemlerle (para yatırma ve çekme) değiştirilebilmelidir.
        Kapsülleme (encapsulation) prensibini kullanarak bakiyeye 
        doğrudan erişimi engelleyeceğiz ve işlemler sırasında gerekli kontrolleri yapacağız.

       Kapsülleme (Encapsulation): Verileri dışarıya karşı korumak ve kontrollü 
                erişim sağlamak için kapsülleme prensibini kullanın.
       Veri Doğrulama: Metotlar içinde girilen tutarların geçerli olup olmadığını kontrol edin.
       Metot İsimlendirme: Metot isimlerinin anlamlı ve eylem odaklı 
        olmasına dikkat edin (örneğin, Deposit, Withdraw).
       */
            #endregion

            Vatandas vatandas = new Vatandas();
            Console.WriteLine("Adınız:");
            vatandas.AdSoyad=Console.ReadLine();
            Console.WriteLine("Tc No:");
            vatandas._Tc=long.Parse(Console.ReadLine());

            Console.WriteLine($"Adınız: {vatandas.AdSoyad} Tc: {vatandas._Tc}");


        }
    }
    class Vatandas
    {
        public string AdSoyad { get; set; }
        private long TC;

        public long _Tc
        {
            get { return TC; }

            set
            {
                if (value.ToString().Length==11)
                {
                    TC=value;
                }
                else
                {
                    TC=0;
                    Console.WriteLine("Tc 11 haneli olmalıdır.");
                }
            }
        }

    }
}

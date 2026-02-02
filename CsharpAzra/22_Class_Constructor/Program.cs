namespace _22_Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Garbage Collector:Bütün kodlar değişkenler methods her yapı ram bellekte tutulur.
             * Ram bellek belirli bir dolulupa ulaştığında en eski en az kullanılan
             * veya en kolay tanımlanabilir yapıları siliyor.
             * ****Constructor****
             * Class ile aynı isme sahiptir
             * Herhangi  bir dönüş terimi almaz void int return vb. yoktur.
             * default olarak boş şekilde görünmez-gizli tanımlanır
             * Classtan instance alındığı an çalışır
             * Destructor yıkıcı method bu yapı garbage collector yapısını destekler ve doluluğu engeller
             * C# da otomatik olarak bu yapı çalışır.
             
             */
            Custommer custommer = new Custommer();
           

            custommer.Ad="Erkan";
            custommer.Soyad="Türk";
            custommer.Yas="31";
            custommer.Yaz();
            Custommer custommer2 = new Custommer("Azra", "Şakak", "23");
        }
    }
    class Custommer
    {
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Yas { get; set; } = string.Empty;

        public void Yaz()
        {
            Console.WriteLine($" Müşteri: {Ad} {Soyad} {Yas}");
        }
        public Custommer(string ad, string soyad, string yas)//Yapıcı Method
        {
            Ad= ad;
            Soyad= soyad;
            Yas= yas;
            Console.WriteLine("Parametreli Constructor çalıştı");
            Console.WriteLine($" Müşteri: {Ad} {Soyad} {Yas}");
        }
        //Ctor ile oluşturabiliriz ve overload ctor olabilir.
        public Custommer()
        {
            Console.WriteLine("Boş ctor çalıştı");
        }

    }
}

namespace _23_Class_Primary_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel("Azra", "Şakak", "23");
            personel.Yaz();
            Ogretmen ogretmen = new Ogretmen("Erkan", "Türk", "Yazılım");
            ogretmen.Yaz();
        }
    }
    class Personel(string ad, string soyad, string yas)//Primary constructor Sınıf tarafından parametreler alınır ve yazdırılır
    {
        public string Ad { get; } = ad;
        public string Soyad { get; } = soyad;
        public string Yas { get; } = yas;

        public void Yaz()
        {
            Console.WriteLine($" Personel: {Ad} {Soyad} {Yas}");
        }
    }
    class Ogretmen(string ad, string soyad, string brans)
    {
        public void Yaz()
        {
            Console.WriteLine($" Öğretmen: {ad} {soyad} {brans}");
        }
    }
}

namespace _04_String_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Methodları
            string metin = "C# Dersleri";
            string[] adSoyad = { "Erkan", "Türk" };
            string ad = "Azra";
            string soyad = "Şakak";
            string text = "    String Metinler    ";
            string adlar = "Erkan,Tahsin,Onur,Altan,Furkan";

            Console.WriteLine($"String Uzunluğu: {metin.Length}");
            Console.WriteLine($"String Büyültme {metin.ToUpper()}");
            Console.WriteLine($"String Küçültme {metin.ToLower()}");
            Console.WriteLine("Değer gir Var mı Öğren");
            //string ara =Console.ReadLine();
            bool buldum = metin.Contains("C#");
            Console.WriteLine("Var mı ? "+buldum);
            string degistirilmisMetin = metin.Replace("C#", "Yazlım");
            Console.WriteLine(degistirilmisMetin);
            string birlestirilmisDizi = string.Join(" ", adSoyad);
            Console.WriteLine(birlestirilmisDizi);

            string birlestirilmisMetin = string.Concat(ad, " ", soyad);
            Console.WriteLine(birlestirilmisMetin);

            Console.WriteLine("Boşluk temizleme: "+text.Trim());
            Console.WriteLine("Boşluk temizleme: "+text.TrimStart());
            Console.WriteLine("Boşluk temizleme: "+text.TrimEnd());
            string[] adDizisi = adlar.Split(',');
            foreach (string isim in adDizisi)
            {
                Console.WriteLine(isim);
            }
            string parcalanmisMetin = metin.Substring(3, 4);
            Console.WriteLine(parcalanmisMetin);

            string str = "25";
            string str2 = "25.5";
            Console.WriteLine(string.Equals(str, str2));

            string ifade = "C# Dersleri";

            Console.WriteLine(ifade.StartsWith("C#"));

            string deger = "dqwqwe";
            Console.WriteLine(string.IsNullOrEmpty(deger));

            Console.WriteLine("Değer giriniz");
            string deger2 = Console.ReadLine();

            if (string.IsNullOrEmpty(deger2))
            {
                Console.WriteLine("Boş değer girdiniz");
            }
            else
            {
                Console.WriteLine("Değeriniz: " + deger2);
            }
        }
    }
}

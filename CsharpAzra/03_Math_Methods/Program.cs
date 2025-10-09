namespace _03_Math_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Matematiksel işlemler için kullanılan hazır methodlar
            //Console.WriteLine();

            Console.WriteLine($"Pi sayısı: {Math.PI}");//Hazır math kütüphanesinden pi sayısını çağırdık
            Console.WriteLine($"Karekök Alma: {Math.Sqrt(25)}");
            Console.WriteLine($"Üs Alma {Math.Pow(2, 3)}");
            Console.WriteLine($"Mutlak Değer Alma {Math.Abs(-30)}");
            Console.WriteLine($"Max değerini alma {Math.Max(50, 30)}");
            Console.WriteLine($"Min değerini alma {Math.Min(50, 30)}");
            Console.WriteLine($"Tam Yuvarlama {Math.Round(3.49)}");
            Console.WriteLine($"Yukarı Yuvarlama {Math.Ceiling(3.01)}");
            Console.WriteLine($"Aşağı Yuvarlama {Math.Floor(3.99)}");

        }
    }
}

namespace _32_Generic_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Generic Type 
             * Aynı tasarımda farklı tiplerle çalışan yapılar oluşturur
             * Kod tekrarını önler
             * Tip güvenliği saplar 
             * LINQ yapısının temelini oluşturur
             * <T> parametresi kullanılarak tip belirlenir
             * Bu yapı kullanılırken generic bir sınıf yapısında generic property yada method olarak kullanılır
             * <T> olarak belirtilen değer gelecek değer belirli olmaz yani buraya uygun bir değer belli değildir 
             * Fakat bu yapıyı miras alan sınıflar bu yapıda <T> olarak bırakılan yapıyı doldurmalıdır
             * T işlemi type ı temsil eder type yapıları şunlardır > string int char object double class v.b yapılar 
             */

            Test<string> test = new Test<string>(); //T olarak tanımlanan yapı kullanılırken belirtilmelidir
            test.NonGenericField = 10;
            test.GenericField = "Generic";
            Test<char> test2 = new Test<char>();
            test2.GenericField = 'A';
            Test<double> test3 = new Test<double>();
            test3.GenericField = 30.99;

            Console.WriteLine(test.GenericField + " " + test2.GenericField + " " + test3.GenericField);
            Urun<double> urun = new Urun<double>(222, 1.20);
            Console.WriteLine(urun.ToString());

            Urun<bool> urun2 = new Urun<bool>(true, false);
            Console.WriteLine(urun2.ToString());

            Urun<DateTime> urun3 = new Urun<DateTime>(DateTime.Now,DateTime.Now.AddDays(1));
            Console.WriteLine(urun3.ToString());
        }
    }
}

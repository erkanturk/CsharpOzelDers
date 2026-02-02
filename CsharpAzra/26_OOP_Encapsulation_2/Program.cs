namespace _26_OOP_Encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba._Hiz=200;
            // araba._Hiz+=75;
            Console.WriteLine(araba._Hiz);
            araba.Hizlanma(250);
            araba.Yavasla(100);
            araba.Yavasla(100);
            araba.Yavasla(100);
            araba.Yavasla(100);

        }
    }
}

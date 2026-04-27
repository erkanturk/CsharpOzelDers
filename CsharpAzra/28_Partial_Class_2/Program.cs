namespace _28_Partial_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.Marka = "BMW";
            araba.Model = "320";
            araba.UretimYili = "2025";
            araba.ArabaOlustur();
            Araba araba1 = new Araba(1, "Mercedes", "EQS", "2026");
            araba1.ArabaOlustur();
        }
    }
}

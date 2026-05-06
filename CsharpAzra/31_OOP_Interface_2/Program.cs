namespace _31_OOP_Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kus kus = new Kus();
            kus.Uc();
            kus.Yuru();
            kus.Yuz();
            kus.HareketEt();
            Balik balik = new Balik();
            balik.Yuz();
            balik.HareketEt();
            Insan insan = new Insan();
            insan.Yuz();
            insan.HareketEt();
            insan.Yuru();
            
        }
    }
}

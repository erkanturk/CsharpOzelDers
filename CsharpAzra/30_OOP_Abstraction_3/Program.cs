namespace _30_OOP_Abstraction_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Insan insan= new Insan();//İnsan tarafı da aslında yüzen bir nesne fakat mutable inheritance olmadığından eksik özellikte oluyor aynı şekilde kuş hem uçar hem yüzer hem yürür
            insan.Yuru();
            Balik balik = new Balik();
            balik.Yuz();
            Kus kus = new Kus();
            kus.Uc();
        }
    }
}

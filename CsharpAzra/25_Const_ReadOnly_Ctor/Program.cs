namespace _25_Const_ReadOnly_Ctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Const ve readonly
             * Const sadece tanımlandığı yerde değeri atanabilir değiştirilemez
             * ReadOnly tanımlandığı yerde ve constructor tarafından değeri güncellenebilinir ve güvenli kullanım yapısıdır.
            
             
             */
            ConstTest test = new ConstTest(3);
            //test.PiSayisi=2;
            ReadOnlyTest readOnly = new ReadOnlyTest(7);
            //readOnly.OkunacakDeger=6;değeri değiştirilemez
            Console.WriteLine(readOnly.OkunacakDeger);
        }
    }
}

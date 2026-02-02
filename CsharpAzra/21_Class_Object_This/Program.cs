namespace _21_Class_Object_This
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.Kaydet(180, 100);
        }
    }
    class Dikdortgen
    {
        private int En;
        private int Boy;

        public void Kaydet(int En, int Boy)
        {
            this.En=En;
            this.Boy=Boy;

            Console.WriteLine(this.En+" "+this.Boy);

        }
    }
}

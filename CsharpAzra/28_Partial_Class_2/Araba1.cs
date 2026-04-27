using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Partial_Class_2
{
    internal partial class Araba
    {
        public void ArabaOlustur()
        {
            Console.WriteLine("Araba boyanıyor");
            Thread.Sleep(2000);
            Console.WriteLine("Araba Lastikleri takılıyor");
            Thread.Sleep(2000);
            Console.WriteLine("Araba Test Sürüşüne Çıktı");
            Thread.Sleep(2000);
            Console.WriteLine("Araba Hazır");
            Thread.Sleep(2000);
            Console.WriteLine($"Arabanın markası {Marka} Modeli{Model} Üretim Yılı{UretimYili}");

        }
        public Araba()
        {
            
        }
    }
}

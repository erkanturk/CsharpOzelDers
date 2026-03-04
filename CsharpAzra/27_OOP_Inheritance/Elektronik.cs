using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance
{
    internal class Elektronik
    {
        public string Ram { get; set; }
        public string CPU { get; set; }
        public int Mah { get; set; }
        public int Inc { get; set; }

        public void Yaz()
        {
            Console.WriteLine($"Ram:{Ram}\nİşlemci:{CPU}\nBatarya:{Mah}\nEkran Boyutu{Inc}");
        }
    }
}

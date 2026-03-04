using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance
{
    internal class Laptop : Elektronik
    {
        public string EkranKarti { get; set; }

        public new void Yaz()
        {
            base.Yaz();
            Console.WriteLine($"Ekran Kartı:{EkranKarti}");
        }
    }
}

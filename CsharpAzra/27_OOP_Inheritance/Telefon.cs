using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance
{
    internal class Telefon:Elektronik
    {
        public string SarjGirisi { get; set; }

        public new void Yaz()
        {
            base.Yaz();
            Console.WriteLine($"Şarj Girişi:{SarjGirisi}");
        }
    }
}

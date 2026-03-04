using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance_4
{
    internal class Canli
    {
        public bool NefesAliyorMu { get; set; }
        public bool HareketEdiyorMu { get; set; }

        public void Canlilar()
        {
            Console.WriteLine($"Nefes Alıyor mu ? {NefesAliyorMu}\nHareket Ediyor Mu{HareketEdiyorMu}");
        }
    }
}

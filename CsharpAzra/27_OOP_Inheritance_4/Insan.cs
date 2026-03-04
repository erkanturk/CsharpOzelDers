using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance_4
{
    internal class Insan:Canli
    {
        public bool KosuyorMu {  get; set; }=true;
        public Insan()
        {
            HareketEdiyorMu=true;
            NefesAliyorMu=true;
        }
        public new void Canlilar()
        {
            base.Canlilar();
            Console.WriteLine($"Koşuyor mu ?{KosuyorMu}");
        }
    }
}

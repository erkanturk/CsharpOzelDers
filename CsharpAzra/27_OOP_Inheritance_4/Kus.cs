using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance_4
{
    internal class Kus: Canli
    {
        public bool YuzuyorMu {  get; set; }=false;
        public bool UcuyorMu { get; set; }=true;
        public Kus()
        {
            HareketEdiyorMu=true;
            NefesAliyorMu=true;
        }
        public new void Canlilar()
        {
            base.Canlilar();
            Console.WriteLine($"Yüzüyor mu {YuzuyorMu} Ucuyor mu {UcuyorMu}");
        }
    }
}

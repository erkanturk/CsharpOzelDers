using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Const_ReadOnly_Ctor
{
    internal class ConstTest
    {
        public const double PiSayisi = 3.14;
        public ConstTest(double piSayisi)
        {
            //Pi sayısı sadece oluşturulduğu yerde değer atanabilir değiştiremeyiz.
           // PiSayisi=piSayisi;
        }
    }
}

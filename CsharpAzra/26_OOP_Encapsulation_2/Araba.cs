using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_OOP_Encapsulation_2
{
    internal class Araba
    {
        private double hiz;
        private const double maxHiz = 250;

        public double _Hiz
        {
            get { return hiz; }

            set
            {
                if (value>0&& value<=maxHiz)
                {
                    hiz = value;
                }
                else
                {
                    Console.WriteLine($"Hız 0 olamaz  yada {maxHiz} dan fazla olamaz");
                    hiz=0;
                }

            }
        }

        public void Hizlanma(double artis)
        {
            hiz+=artis;
            if (hiz>maxHiz)
            {
                hiz=maxHiz;
                Console.WriteLine($"Hız  {maxHiz} dan fazla olamaz");
            }
            else
            {
                Console.WriteLine($"Şu anki hızınız {hiz} km/s olarak ayarlandı");
            }
        }
        public void Yavasla(double azalt)
        {
            if (hiz>=azalt)
            {
                hiz-=azalt;
                if (hiz==0)
                {
                    Console.WriteLine("Araba durdu");
                }
                else if (hiz!=0)
                {
                    Console.WriteLine("Arabanın mevcut hizi"+hiz);
                }

            }
            else if (hiz>0&&hiz<=azalt)
            {
                hiz=0;

                Console.WriteLine("Araba durdu");
            }
            else
            {
                Console.WriteLine("Fren patladı durmuyor");
            }
            
        }
    }
}

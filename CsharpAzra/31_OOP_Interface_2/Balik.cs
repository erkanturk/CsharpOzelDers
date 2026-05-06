using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Interface_2
{
    internal class Balik : Canli,IYuzenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Ben balığım Suda hareket ederim");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben balığım yüzerim");
        }
    }
}

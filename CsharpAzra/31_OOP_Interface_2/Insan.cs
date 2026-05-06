using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Interface_2
{
    internal class Insan : Canli,IYuzenNesne,IYuruyenNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Ben insanım Koşarım");
        }

        public void Yuru()
        {
            Console.WriteLine("Ben insanım Yürürüm");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben insanım Yüzerim");
        }
    }
}

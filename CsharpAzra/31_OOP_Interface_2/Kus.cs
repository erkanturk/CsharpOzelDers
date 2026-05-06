using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Interface_2
{
    internal class Kus : Canli, IYuruyenNesne, IYuzenNesne, IUcanNesne
    {
        public override void HareketEt()
        {
            Console.WriteLine("Ben kuşum bulutlarda süzülürüm");
        }

        public void Uc()
        {
            Console.WriteLine("Ben kuşum uçarım");
        }

        public void Yuru()
        {
            Console.WriteLine("Ben kuşum yürürüm");
        }

        public void Yuz()
        {
            Console.WriteLine("Ben kuşum Yüzerim");
        }
    }
}

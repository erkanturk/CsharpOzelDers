using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_Polymorphism_3
{
    internal class Eft:BankaSistem
    {
        public override void ParaTransfer(int para)
        {
            const double islemUcreti = 1.20;
            Console.WriteLine($"{para * islemUcreti} eft yapıldı");
        }
    }
}

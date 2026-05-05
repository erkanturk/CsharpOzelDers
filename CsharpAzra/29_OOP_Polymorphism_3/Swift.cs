using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_Polymorphism_3
{
    internal class Swift:BankaSistem
    {
        public override void ParaTransfer(int para)
        {
            const double transferBedeli = 1.30;
            Console.WriteLine($"{para * transferBedeli} swift yapıldı");
        }
    }
}

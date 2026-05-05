using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_OOP_Polymorphism_3
{
    internal class BankaSistem
    {
        public virtual void ParaTransfer(int para)
        {
            const double transferBedeli = 1.02;
            Console.WriteLine($"{para*transferBedeli} transfer yapıldı");

        }
    }
}

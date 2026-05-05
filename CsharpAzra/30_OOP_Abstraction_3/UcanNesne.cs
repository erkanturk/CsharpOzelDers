using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_OOP_Abstraction_3
{
    abstract class UcanNesne
    {
        protected UcanNesne()
        {
            Console.WriteLine("Kuş ctor çalıştı");
        }
        public abstract void Uc();
    }
}

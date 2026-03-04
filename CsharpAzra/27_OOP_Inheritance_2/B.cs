using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance_2
{
    internal class B:A
    {
        public string test {  get; set; }
        public B()
        {
            Console.WriteLine("B sınıfı ctor");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Const_ReadOnly_Ctor
{
    internal class ReadOnlyTest
    {
        public readonly int OkunacakDeger = 5;
        public ReadOnlyTest(int sayi)
        {
            OkunacakDeger=sayi;
        }
        public void Degistir()
        {//sadece constructor tarafında değeri güncellenir.
            //OkunacakDeger =10;
        }
    }
}

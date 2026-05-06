using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Generic_Type
{
    internal class Urun<T>(T fiyat,T kdv)
    {
        public T Fiyat { get; set; } = fiyat;
        public T Kdv { get; set; } = kdv;
        public override string ToString()
        {
            return $"Fiyat:{Fiyat} Kdv:{Kdv}";
        }
    }
}

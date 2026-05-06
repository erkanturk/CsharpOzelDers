using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Generic_Type
{
    internal class Test<T>//Generic bir sınıf olduğunu belirttik 
    {
        public int NonGenericField { get; set; }//int değer alabilir sadece
        public T GenericField { get; set; }//Generic yapı
    }
}

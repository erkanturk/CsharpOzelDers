using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Interface_3
{
    internal class Ogretmen : Insan, ICalisan
    {
        public string Brans {  get; set; }
        public int SgkNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Maas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int MaasHesapla()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Interface_3
{
    internal class Hizmetli : Insan, IOzelIsci
    {
        public string SozlesmeTarihi { get ; set; }
        public int SgkNo { get; set ; }
        public int Maas { get ; set ; }

        public int MaasHesapla()
        {
            return Maas = 30000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_OOP_Interface_3
{
    internal interface ICalisan
    {
        int SgkNo {  get; set; }
        int Maas {  get; set; }
        int MaasHesapla();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Partial_Class_2
{
    internal partial class Araba
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string UretimYili { get; set; }

        public Araba(int id,string marka,string model,string uretimYili)
        {
            Id = id;
            Marka = marka;
            Model = model;
            UretimYili=uretimYili;
        }
    }
}

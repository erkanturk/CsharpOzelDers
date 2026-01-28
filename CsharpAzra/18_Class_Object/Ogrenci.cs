using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Class_Object
{
    internal  class Ogrenci
    {
        private int OgenciNo;
        private string OgrenciAdi;
        private string OgrenciSoyadi;
        private string Bolumu;

        private void Test()
        {
            Console.WriteLine($"{OgrenciAdi} {OgrenciSoyadi} {Bolumu}");
        }
    }
}

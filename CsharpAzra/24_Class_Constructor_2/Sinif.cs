using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Class_Constructor_2
{
    internal class Sinif
    {
        public double No { get; set; }
        public double Kapasite { get; set; }

        public Sinif()
        {
            Console.WriteLine("Parametresiz Ctor çalıştı");
        }
        public Sinif(int no)
        {
            this.No = no;
            Console.WriteLine($"No: {no} değeri alan ctor");
        }
        public Sinif(double no, double kapasite)
        {
            No = no;
            Kapasite = kapasite;
            Console.WriteLine("İki parametreli ctor");
        }
        public Sinif(double no , int kapasite)
        {
            Console.WriteLine("iki parametreli double int ctor");
        }

    }
}

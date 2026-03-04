using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_OOP_Inheritance_3
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tc { get; set; }
        public DateTime IseGirisTarihi { get; set; }

        public Personel()
        {
            IseGirisTarihi = DateTime.Now;
        }
        public void Kayit()
        {
            Console.WriteLine("Id:");
            this.Id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ad:");
            this.Ad=Console.ReadLine();
            Console.WriteLine("Soyad:");
            this.Soyad=Console.ReadLine();
            Console.WriteLine("Tc:");
            this.Tc=Console.ReadLine();

        }


    }
}

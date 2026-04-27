using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Partial_Class
{
    internal partial class Personel
    {
        public void IsimKaydet()
        {
            Console.WriteLine("Ad Giriniz");
            Name = Console.ReadLine();

        }
        public void AdresBilgileri()
        {
            Console.WriteLine("Adres bilgisi");
            Address = Console.ReadLine();
            Console.WriteLine("Şehir");
            City = Console.ReadLine();
        }

        public string PhoneKaydet()
        {
            Console.WriteLine("Telefon Numarası");
            Phone = Console.ReadLine();
            return Phone;
        }
    }
}

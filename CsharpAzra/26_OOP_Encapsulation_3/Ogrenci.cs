using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_OOP_Encapsulation_3
{
    internal class Ogrenci
    {
        private string Ad;
        private int Yas;
        private string Iban;

        public string _Ad
        {
            get { return Ad; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (value.StartsWith("A"))
                    {
                        Ad=value;
                        Console.WriteLine(Ad);
                    }
                    else
                    {
                        Console.WriteLine("A ile başlamalıdır.");
                    }
                }
                else
                {
                    Console.WriteLine("Ad değeri boş olamaz");
                }
            }
        }
        public int _Yas
        {
            get { return Yas; }
            set
            {
                if (value>18)
                {
                    Yas=value;
                }
                else
                {
                    Console.WriteLine("Yaş 18 den küçükleri okulumuza almıyoruz.");
                }

            }

        }
        public void IbanAl(string metin)
        {
            string ibanNo = metin.Substring(2);
            string deger = metin.Substring(0, 2);
            long Iban;
            if (long.TryParse(ibanNo, out Iban)&&metin.Length==16)
            {
                this.Iban=Iban.ToString();
                Console.WriteLine(deger+this.Iban);
            }
            else
            {
                Console.WriteLine("16 Karakter uzunluğunda olmalıdır.");
            }
        }

    }
}

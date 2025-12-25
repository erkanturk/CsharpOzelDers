using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Class_Object
{
    internal class Ogretmen
    {
        //= 0 initializetion (yüklenme durumunda ) varsayılan değer atama
        //=string.Empty: null yerine boş stringle başla
        internal int OgretmenNo { get; set; } = 0;//get var olan değeri getirir set var olan değeri günceller
        internal string OgretmenName { get; set; } = string.Empty;
        internal string OgretmenSurName { get; set; } = string.Empty;
        internal int Phone { get; set; } = 0;

        internal void OgretmenTest()
        {
            if (OgretmenName is not null)
            {
                Console.WriteLine($"Öğretmen Adı {OgretmenName} Soyad {OgretmenSurName} Telefon {Phone}");
            }
        }

    }
}

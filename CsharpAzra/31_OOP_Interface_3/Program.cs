namespace _31_OOP_Interface_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hizmetli hizmetli = new Hizmetli();
            hizmetli.Ad = "Onur";
            hizmetli.Soyad = "Yağız";
            hizmetli.Maas = hizmetli.MaasHesapla();
            hizmetli.SgkNo = 12345;
            hizmetli.SozlesmeTarihi = "2020-05-13";
            Console.WriteLine($"Ad:{hizmetli.Ad} Soyad:{hizmetli.Soyad} Maaş {hizmetli.Maas} SgkNo:{hizmetli.SgkNo} Sözleşme tarihi:{hizmetli.SozlesmeTarihi}");
        }
    }
}

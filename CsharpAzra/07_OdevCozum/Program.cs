namespace _07_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev1
            Random random = new Random();
            int[] dizi = new int[random.Next(10, 21)];

            for (int j = 0; j < dizi.Length;)
            {
                int sayi = random.Next(0, 101);
                bool varMi = false;
                foreach (int d in dizi)
                {
                    if (d == sayi)
                    {
                        varMi = true;
                        break;
                    }
                }
                if (varMi == false)
                {
                    dizi[j] = sayi;
                    j++;
                }

            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************");
            int enBuyuk = dizi[0];
            int enKucuk = dizi[0];
            foreach (int deger in dizi)
            {
                if (deger > enBuyuk)
                {
                    enBuyuk = deger;
                }
                if (deger < enKucuk)
                {
                    enKucuk = deger;
                }
            }
            Console.WriteLine("En büyük eleman: " + enBuyuk);
            Console.WriteLine("En küçük eleman: " + enKucuk);
            #endregion

            Indirim();
        }
        static void Indirim()
        {
            Console.WriteLine("1.Ürün Fiyatını Giriniz");
            double fiyat =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Ürün Fiyatını giriniz");
            double fiyat2=Convert.ToDouble(Console.ReadLine());
            if(fiyat>fiyat2)
            {
                fiyat *= 0.7;
            }
            else
            {
                fiyat2 *= 0.7;
            }
            Console.WriteLine("3. üründe %50 indirim var almak ister misin E/H");
            string cevap=Console.ReadLine();
            if(cevap.ToUpper()=="E")
            {
                Indirim3(fiyat, fiyat2);
            }
            else if(cevap.ToUpper()=="H")
            {
                Console.WriteLine($"Ödeme: {fiyat+fiyat2} ");
            }
            else
            {
                Console.WriteLine("Hatalı işlem");
            }
            

        }
        static void Indirim3(double f, double f2)
        {
            Console.WriteLine("3.ürün fiyatı");
            double f3=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Ödeme: {f+f2+(f3/2)}");
        }
    }
}

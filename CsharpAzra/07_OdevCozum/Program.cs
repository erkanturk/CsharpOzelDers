namespace _07_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random random =new Random();
            int[] dizi = new int[random.Next(10, 21)];
            
            for (int j = 0; j < dizi.Length;)
            {
                int sayi = random.Next(0, 101);
                bool varMi = false;
                foreach (int d in dizi)
                {
                    if(d==sayi)
                    {
                        varMi = true;
                        break;
                    }
                }
                if (varMi==false)
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
            int enBuyuk=dizi[0];
            int enKucuk=dizi[0];
            foreach (int deger in dizi)
            {
                if(deger>enBuyuk)
                {
                    enBuyuk = deger;
                }
                if(deger<enKucuk)
                {
                    enKucuk = deger;
                }
            }
            Console.WriteLine("En büyük eleman: "+enBuyuk);
            Console.WriteLine("En küçük eleman: "+enKucuk);
        }
    }
}

namespace _06_return_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region ödev
            //Bir dizinin eleman sayısı 10 ile 20 arasında olacak şekilde sistem tarafında otomatik atılmaktadır.
            //Bu dizinin elemanlarını da sistem 0,100 arasında otomatik atmaktadır.
            //Otomatik oluşturulan bu dizinin eleman sayısını ve elemanlarını kullanıcıya gösteriniz
            //Aynı sayılar tekrar atanmayacak
            //Dizideki en büyük ve en küçük sayılar sort() kullanılmadan bulup ekrana yazdırılacak 
            #endregion
            #region Ödev method
            /*
            kullanıcıdan iki adet ürün fiyatı alınacak pahalı olan ürüne 
            %30 indirim uygulanacak 
            kullanıcıya 3. ürünü almak ister misiniz diye soracağız eğer 
            evet derse başka bir methoda yönlendirip 
            3. ürün fiyatı isteyeceğiz 3. ürüne de %50 indirim uygulayıp 
            toplam 1.ürün 2.ürün(%30) 3.ürünün(%50) 
            fiyatlarını toplayıp 
            Ekrana toplam fiyatı yazdıracağız 
            Eğer istemez ise 3. ürünü 2 üründen pahalı olan fiyata indirim 
            uygulayıp toplamı ekranda göstereceğiz.
            
            
            */
            #endregion
            //int sonuc = Sayi();
            //Console.WriteLine(sonuc);

            //Console.WriteLine(Sayi());
            //string hammade = "Plastik";
            //if (Yap(hammade)=="OYUNCAK")
            //{
            //    Console.WriteLine("Mağzaya gönderim yapıldı");
            //}
            //else
            //{
            //    Console.WriteLine("Mağazaya gönderim yapılmadı");

            //}
            //Console.WriteLine(Topla(50,25));
            Cevapla("Nasılsın");
            Console.WriteLine(Cevapla2("Nasılsın")); 

        }
        //static int Sayi()
        //{
        //    return 10;
        //}
        //static string Yap(string madde)
        //{
        //    string islem = madde;
        //    islem="Oyuncak";
        //    islem=islem.ToUpper();
        //    Console.WriteLine(islem);
        //    return islem;
        //}
        //static int Topla(int a, int b)
        //{
        //    return a + b;
        //}
        static void Cevapla(string deger)
        {
            Console.WriteLine(deger);
        }
        static string Cevapla2(string deger)
        {
            string cevap = "İyiyim sen";
            return cevap;
        }

    }
}

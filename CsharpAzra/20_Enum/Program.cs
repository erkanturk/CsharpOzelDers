namespace _20_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Enum
             * Enumlar sabitler olarak adlandırılır bu veri tipi hem sayısal hem metinsel olarak bize değer döndürür
             * sabit veri yapılarında genelde enum yapısı tercih edilir bir veriyi veri tabanında sayısal olarak tutup
             * metinsel olarak kullanmamızı sağlar
             * bu yapıda varsayılan değer olarak 0 değeri ile başlar eğer bir değer verilirse sonraki 
             * değer son verilen değerin 1 fazlası olarak gelir 2 aynı sayısal değer alamaz
             * ilk verilen değeri takip ederek benzersiz olarak artar
             * double float decimal gibi yapı kullanılamaz
             * int long byte vb veri tipi kullanılır.
            
            */

            #region Ödev
            //KitapKategori adında  enum oluşturarak içerisine, BilimKurgu=0,
            //DunyaKlasikleri=1, Psikoloji=2 olmak üzere 3 kategori ekleyelim.
            //Kullanıcıdan string olarak kategori girmesini isteyelim, girilen değeri
            //KitapKategori enum'ına çevirerek switch case ile kontrol edip aşağıda
            //belirtilen şekilde mesajı yazdıran programı yazalım.
            //BilimKurgu ise: "Bilim Kurgu kategorisindeki kitaplar A reyonundadır."
            //DunyaKlasikleri ise:  "Dünya Klasikleri kategorisindeki kitaplar B reyonundadır."
            //Psikoloji ise:  "Psikoloji kategorisindeki kitaplar C reyonundadır."
            #endregion
            //Otomobil otomobil = new Otomobil();
            //otomobil.Marka=Markalar.Honda;
            //otomobil.Vites=Vitesler.Otomatik;
            //otomobil.Renk=Renkler.Kırmızı;
            //otomobil.MotorHacmi=1600;
            //otomobil.UretimYili="2025";

            //otomobil.OzellikYaz();

            //Console.WriteLine(Markalar.Renault+" "+Renkler.Beyaz+" "+Vitesler.YarıOtomatik);
            //Console.WriteLine((int)Markalar.Renault+" "+(int)Renkler.Beyaz+" "+(int)Vitesler.YarıOtomatik);
            //int sayi = (int)Markalar.Mercedes;
            //Console.WriteLine(sayi);
            //Markalar marka = Markalar.Ford;
            //Console.WriteLine(marka);
            //Console.WriteLine((byte)marka);

            //string[] markalar = Enum.GetNames(typeof(Markalar));
            //foreach (var item in markalar)
            //{
            //    Console.WriteLine(item);
            //}
            //int[] ints = (int[])Enum.GetValues(typeof(Markalar));
            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}
            //bool sonuc = Enum.IsDefined(typeof(Markalar), 5);//Isdefined yapısı bize True veya False olarak dönüş yapar
            //Console.WriteLine(sonuc);
            //bool sonuc2 = Enum.IsDefined(typeof(Markalar), "Bmw");
            //Console.WriteLine(sonuc2);
            //int sayi = 15;
            //for (int i = 0; i <=sayi; i++)
            //{
            //    string backColor = i.ToString();
            //    string foreColor = i.ToString();
            //    Console.BackgroundColor=(ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            //    Console.ForegroundColor=(ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            //    Console.Clear();
            //    Thread.Sleep(1000);
            //    if (i==15)
            //    {
            //        i=0;
            //        continue;
            //    }

            //}
            while (true)
            {
                Console.WriteLine("BackroundColor giriniz");
                string backgroundColor = Console.ReadLine();
                Console.WriteLine("Yazı rengi ");
                string foreColor = Console.ReadLine();

                Console.BackgroundColor=(ConsoleColor)Enum.Parse(typeof(ConsoleColor), backgroundColor);
                Console.ForegroundColor=(ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
                Console.WriteLine("Renk ayarlandı");
                Console.WriteLine("Renk ayarlandı");
                Console.WriteLine("Renk ayarlandı");
                Console.WriteLine("Renk ayarlandı");
                Console.WriteLine("Renk ayarlandı");
            }
        }
    }
    enum Markalar { Honda = 1, Mercedes, Bmw, Renault, Ford }
    enum Vitesler { Manuel, Otomatik, YarıOtomatik }
    enum Renkler { Kırmızı, Mavi, Beyaz, Turuncu = 5, Yeşil, Mor }

    class Otomobil
    {
        public Markalar Marka;
        public Vitesler Vites;
        public Renkler Renk;
        public int MotorHacmi;
        public string UretimYili;

        public void OzellikYaz()
        {
            Console.WriteLine(Marka+" "+ Vites+ " "+MotorHacmi+" "+UretimYili+" "+Renk+" ");
        }
    }
}

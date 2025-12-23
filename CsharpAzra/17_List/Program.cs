namespace _17_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List generic typelar ile çalışan
             *  ve verdiğimiz değere göre o veri tipinde birden fazla elemanı aynı tipte tutan ve index değerlerine göre getiren 
             * Collection yapısıdır.
             * Diziden farklı olarak bir uzunluk belirtmemize gerek yok sınırı yoktur. 
             * list yapısı içerisinde her type ı barındırır bu yapılar datastruct olarak 
             * (int,string, double,datetime veya sınıf yapıları olabilir)
             
             */
            //Boş liste yapısı
            //List<string> list = new List<string>();//type safe yapı için generic yapı kullanırız bize tip güvenliğini sağlar.
            //list.Add("Öğrenci 1");//sadece string değerler tutan list yapısı
            //list.Add("Öğrenci 2");
            //list.Add("Öğrenci 3");
            //list.Add("Öğrenci 4");
            //list.Add("Öğrenci 5");
            //list.Add("Öğrenci 6");
            //list.Add("Öğrenci 7");
            //list.Add("Öğrenci 8");
            //list.Add("Öğrenci 9");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //list.ForEach(i => Console.WriteLine(i));//method foreach linq sorgusu ve lamda experation
            #region örnekler
            //List<int> yaslar = new List<int>() { 10, 20, 30, 40 };
            //yaslar.Add(25);
            //yaslar.Add(25);
            //yaslar.AddRange(new List<int> { 32, 33, 34, 19, 21 });

            ////Console.WriteLine("Listeye yaş ekle");
            ////int yas = Convert.ToInt32(Console.ReadLine());
            ////yaslar.Add(yas);
            ////foreach (int y in yaslar)
            ////{
            ////    Console.WriteLine(y);
            ////}
            //foreach (int i in yaslar)
            //{
            //    if (i>30)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //for (int i = 0; i<yaslar.Count; i++)
            //{
            //    if (yaslar[i]>30)
            //    {
            //        Console.WriteLine(yaslar[i]);
            //    }
            //}
            ////Lambda => yapısı bir değişken oluştururuz ve bu değişken üzerinden verilere ulaşıp kontrol ederiz
            ////linq sorgularında çok sık kullanırız
            //Console.WriteLine("linq");
            //yaslar.Where(yas => yas>30).ToList().ForEach(yas => Console.WriteLine(yas));
            //int bul = yaslar.Find(y => y==19);
            //Console.WriteLine(bul);
            ////Aggregate Function
            //double ortlama = yaslar.Average();
            //Console.WriteLine(ortlama);
            //double toplam = yaslar.Sum();
            //Console.WriteLine(toplam);
            //double max = yaslar.Max();
            //Console.WriteLine(max);
            //double min = yaslar.Min();
            //Console.WriteLine(min);

            //int index = yaslar.FindIndex(y => y>=19);
            //Console.WriteLine(index);
            //var deger = yaslar.FirstOrDefault(y => y==19);
            //Console.WriteLine(deger);
            #endregion
            #region örnek 2
            Kisi kisi = new Kisi();//instance (örneklem) nesneleme
            kisi.Ad="Erkan";
            kisi.Soyad="Türk";
            kisi.Yas=31;
            kisi.DogumTarihi=DateTime.Now;

            Kisi kisi2 = new Kisi();
            kisi2.Ad="Azra";
            kisi2.Soyad="Şakak";
            kisi2.Yas=23;
            kisi2.DogumTarihi=DateTime.Now;

            Kisi kisi3 = new Kisi();
            kisi3.Ad="Furkan";
            kisi3.Soyad="Uçan";
            kisi3.Yas=25;
            kisi3.DogumTarihi=DateTime.Now;


            //Console.WriteLine(kisi.Ad);
            //Console.WriteLine(kisi2.Ad);
            //Console.WriteLine(kisi3.Ad);

            //List<string> adlar = new List<string>();
            //adlar.Add(kisi.Ad+" "+kisi.Soyad);
            //adlar.Add(kisi2.Ad+" "+kisi2.Soyad);
            //adlar.Add(kisi3.Ad+" " + kisi3.Soyad+" "+kisi3.Yas);//yaşları birleştirip getirdi "Furkan Ucan 25";
            //adlar.Add($"{kisi.Ad} {kisi.Soyad} {kisi.Yas}");//MEtinsel olarak değerler gelir
            //adlar.Add(kisi.Yas);

            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}

            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(kisi);
            kisiler.Add(kisi2);
            kisiler.Add(kisi3);
            var deger = kisiler.Sum(k => k.Yas);
            Console.WriteLine(deger);
            foreach (Kisi item in kisiler)
            {
               
                
                Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Yas+" "+item.DogumTarihi );
            }
            #endregion

        }
        class Kisi
        {
            public string Ad;
            public string Soyad;
            public int Yas;
            public DateTime DogumTarihi;
        }
    }
}

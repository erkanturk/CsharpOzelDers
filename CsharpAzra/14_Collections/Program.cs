using System.Collections;

namespace _14_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Koleksiyon yapıları
             * Arraylere benzer olarak içerisinde birden fazla veriyi barındırabilen  data yapılarıdır
             * string[], int[] char[] gibi arrayler sadece ilgili data tipini tutarken
             * Collections yapıları daha spesifik ve karmaşık  yapılarıda beraber birden çok data tipini içinde 
             * barındırabilir
             * ICollections=>Koleksiyon yapılarının temel arayüzüdür => System.Collections
             * ArrayList, Hashtable, Queue, Stack, SortedList,List(generic) bu yapılar ICollections arayüzünden türemiştir.
             * Bu yapıların hepsind Dizi yapısı gibi sabit uzunluk değeri verilmesine gerek yoktur
             * 2 üzeri n olarak büyüyebilirler
             * Arraylist yapısı boxing unboxing işlemi yapar bu yüzden performans kaybı yaşanabilir
             * Arraylist yapısı Type Safe değildir (Tip güvenliği yoktur) Her veri tipini içerisinde barındırabilir.
             * Queue ve Stack yapıları FIFO ve LIFO mantığı ile çalışır Queue (First in First out) ilk giren ilk çıkar
             * Stack (Last in First out) son giren ilk çıkar
             * Hastable Dictionary yapısına benzer düzensiz tablo key value mantığı ile çalışır
             * SortedList Düzenli Liste Dictionary yapısındadır sözlük yapısı gibi key value mantığı ile çalışır
             
            */

            #region Queue Kuyruk çalışma yapısı
            /* Queue queue = new Queue();*/ //Fifo
                                            //queue.Enqueue(1);//ilk değer
                                            //queue.Enqueue("2");
                                            //queue.Enqueue("3");
                                            //queue.Enqueue("4");
                                            //queue.Enqueue(5);
                                            //queue.Enqueue(6);//Son değer
                                            //foreach (var item in queue)
                                            //{
                                            //    Console.WriteLine(item);
                                            //}
                                            //queue.Dequeue();//ilk elemanı çıkarır
                                            //Console.WriteLine("************");
                                            //foreach (var item in queue)
                                            //{
                                            //    Console.WriteLine(item);
                                            //}
                                            //Console.WriteLine("***********");
                                            //Console.WriteLine(queue.Peek());
                                            //queue.Clear();
                                            //foreach (var item in queue)
                                            //{
                                            //    Console.WriteLine(item);
                                            //}

            //Queue kuyruk = new Queue();
            //kuyruk.Enqueue("Ali");
            //kuyruk.Enqueue("Veli");
            //kuyruk.Enqueue("Ahmet");
            //kuyruk.Enqueue("Mehmet");
            //kuyruk.Enqueue("Azra");
            //for (int i = 5; i >= kuyruk.Count; i--)//count bize toplam miktarını getirir
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine($"{i}. sıradasınız");
            //    if (kuyruk.Count == 1)
            //    {
            //        Console.WriteLine("Sıra Sizde: " + kuyruk.Peek());
            //    }
            //    else
            //    {
            //        kuyruk.Dequeue();
            //    }
            //}
            #endregion
            #region Stack Yığın Lifo
            //Stack yigin = new Stack();
            //yigin.Push(1);
            //yigin.Push(2);
            //yigin.Push(3);
            //yigin.Push(4);
            //foreach (var item in yigin)
            //{
            //    Console.WriteLine(item);
            //}
            //yigin.Pop();//ilk değeri çıkarır
            //foreach (var item in yigin)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(yigin.Peek());


            #endregion

            #region SortedList Çalışma Prensibi
            /*Sözlük tabanlı bir koleksiyon yapısıdır  İçerisinde key value mantığı ile çalışır
            * Key değerleri benzersiz olmalıdır aynı değer birden fazla kez kullanılamaz
            * Key değerleri sıralı bir şekilde tutulur
            * Key değerleri null olamaz
            * Value değerleri null olabilir
            * Key değerleri aynı veri tipi üzerinden olmalıdır value'lar için böyle bir kısıtlama yoktur
            */

            //SortedList iller = new SortedList();
            //iller.Add(01, "Adana");
            //iller.Add(34, "İstanbul");
            //iller.Add(06, "Ankara");
            //iller.Add(16, "Bursa");
            //iller.Add(35, "İzmir");
            //iller.Add(05, "Amasya");
            ////iller.Add(05, 123); unique key değerleri olmalıdır
            ////iller.Add("07", "Antalya");
            ////iller.Add(07, 07);
            //foreach (var item in iller)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            ////}
            //Console.WriteLine("***********");
            //iller[06] = "Ankara Merkez";//Eğer değer varsa günceller yoksa ekler
            //iller[37] = "Kastamonu";
            //foreach (DictionaryEntry item in iller)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //Console.WriteLine(iller[37]);
            //Console.WriteLine(iller.ContainsValue("Kastamonu"));//Varsa true yoksa false dönderir
            //Console.WriteLine(iller.ContainsKey(34));
            //Console.WriteLine(iller.GetKey(4));//KEy değerini indexine göre bulma
            //int i = iller.IndexOfValue("Kastamonu");
            //Console.WriteLine(i);


            SortedList<int,string> iller = new SortedList<int, string>();
            iller.Add(01, "Adana");
            iller.Add(34, "İstanbul");
            iller.Add(06, "Ankara");
            iller.Add(16, "Bursa");
            iller.Add(35, "İzmir");
            iller.Add(05, "Amasya");
            //iller.Add(07, 07);//hata verir value string olmalıdır.
            foreach (KeyValuePair<int, string> item in iller)// istediğim değerleri almamı sağlıyor
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            #endregion
            #region Ödev SortedList Tr-En Sözlük
            /*
          sözlük uygulaması istenmektedir.Tr - Eng
       sözlük = { "siyah":"black",,,,}
          kullanıcı 4 girene kadar sorulur.
           1 - Arama
           2 - Çıkarma
           3 - Listeleme
           4 - Çıkış

      Kullanıcı 1'e basarsa ->
          - Aranacak olan kelimeyi giriniz:
          -Bu kelime dizide varsa eng karşılığı yazılır.
          -Yoksa uygulamanın gelişmesine yardımcı olmak ister msiniz(E-H):
              -E ise bu kelimenin karşılığı istenir ve sözlüğe eklenir
              -H ise bişey yapılmaz
      Kullanıcı 2'ye basarsa ->
          - Çıkarılmak istenen kelime :
          -Kelime sözlükte varsa çıkartılır
          - Yoksa uyarı verilir.
      Kullanıcı 3'e basarsa ->
          - Tum key value lar listelenir
          -KEY->VALUE
      Kullanıcı 4'e basarsa ->
          - Döngü sonlanır.
           */
            #endregion
            #region
            /*
             Bir fonksiyon yazın: ToplamAl(params int[] sayilar)
             Bu fonksiyon kendisine verilen sayıların  çift tek ayrı ayrı  toplamını döndürsün.
           
             */
            /*
                Kullanıcıdan alınan bir sayının faktöriyelini hesaplayan recursive bir fonksiyon yazın.
                Örneğin: 5! = 5 × 4 × 3 × 2 × 1 = 120
             
             */
            #endregion
        }
    }
}

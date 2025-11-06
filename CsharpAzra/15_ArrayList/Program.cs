using System.Collections;

namespace _15_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ArrayList
             * Arraylistler içerisinde sınırsız sayıda her değeri barındıran liste yapısıdır
             * Uzunluk miktarı 2 üzeri n diye adlandırılır sınırı yoktur diyebiliriz
             * Yapıyı tanımlarken bir veri tipi veya uzunluk belirtmemize gerek yoktur
             * Tüm yapıları içerisinde barındırabilen be her bir yapıyı listenin elemanı içerisinde indexlerle tutulur
             * Arraylist type safe bir yapı değildir 

             */
            #region Boş arraylist
            //ArrayList arrayList = new ArrayList();//boş arraylist
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add("Test");
            //arrayList.Add(30.5f);
            //arrayList.Add('A');
            //arrayList.Add(DateTime.Now);
            //arrayList.Add(DateTime.Now);
            //arrayList.Add(DateTime.Now);
            //arrayList.Add(DateTime.Now);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arrayList.Count);//Eleman sayısı
            //Console.WriteLine(arrayList.Capacity);//Listenin kapasitesi
            #endregion
            #region Dolu ArrayList
            //ArrayList list = new ArrayList() { "Azra", "Erkan", "Furkan", "Onur", "Birsu", "Tuğba",true,false,DateTime.Now };
            //list.Add("deneme");
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(list[3]);//indexine göre yazdırma

            //Bir arrayliste  char karakterleri ekleme işlemi yapacağız  A >z ye ekleme yapacak ve yazdıracak
            //ArrayList bosListe = new ArrayList();

            //for (char i ='A';i<='z';i++)
            //{
            //    bosListe.Add(i);
            //}
            //foreach (var item in bosListe)
            //{
            //    Console.WriteLine(item);
            //}

            ArrayList sayiList = new ArrayList();
            sayiList.AddRange(new ArrayList { 10, 20, 30, 40, 50, 60, 70 });//Çoklu ekleme yöntemi
            //foreach (var item in sayiList)
            //{
            //    Console.WriteLine(item);
            //}
            int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            sayiList.Add(sayilar);//hata verir dizi yapısının elemanlarını göndermedik diziyi veriğimiz için elemanlarını göremeyiz.
            //sayiList.AddRange(new ArrayList { sayilar });
            //foreach (var item in sayiList)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayiList.Add(sayilar[i]);
            //}
            //foreach (var item in sayiList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }
    }
}

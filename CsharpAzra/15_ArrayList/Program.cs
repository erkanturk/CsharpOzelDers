using System.Collections;

namespace _15_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Manav Projesi Ödev
            /*
          HAL - Toptancı
         * Manava ürün almaya geliyor. Manava "Meyve mi Sebze mi?"
         * 5 adet meyve listelenecek
         * Meyve seçildikten sonra "Kaç Kilo?"
         * Meyve satıldıktan sonra "Başka bir arzunuz var mı?" 
         * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
         * Hayır. "iyi günler" diyerek manav kısmına geçeceğiz
         * 
         * 
          MANAV
         * "Meyve mi Sebze mi?" diye müşteriye soracağız.
         * Halden almış olduğumuz meyve veya sebzeleri listeleyeceğiz.
         * Müşteri ürün seçtikten sonra "Kaç Kilo?" sorusunu sorun
         * Girilen kilo bilgisini manavın halden aldığı kilo ile kıyaslayarak ürün satınız.
         * Elde olan ürün var olan kilosu kadar satılırsa, manavın ürünlerinden silin.
         * Ürün satıldıktan sonra "Başka bir arzunuz var mı?"
         * Evet derse tekrar "Meyve mi Sebze mi?" satırına döndüreceğiz
         * Hayır derse "Afiyet olsun" Müşteri kısmına geçiniz

         MÜŞTERİ
         * Alınan ürünleri ekrana yazdırınız.
          */
            #endregion

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
            //ArrayList list = new ArrayList() { "Azra", "Erkan", "Furkan", "Onur", "Birsu", "Tuğba", true, false, DateTime.Now };
            //list.Add("deneme");
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //Console.WriteLine(list[3]);//indexine göre yazdırma

            //Bir arrayliste  char karakterleri ekleme işlemi yapacağız A > z ye ekleme yapacak ve yazdıracak
            //ArrayList bosListe = new ArrayList();

            //for (char i = 'A'; i <= 'z'; i++)
            //{
            //    bosListe.Add(i);
            //}
            //foreach (var item in bosListe)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList sayiList = new ArrayList();
            //sayiList.AddRange(new ArrayList { 10, 20, 30, 40, 50, 60, 70 });//Çoklu ekleme yöntemi
            ////foreach (var item in sayiList)
            ////{
            ////    Console.WriteLine(item);
            ////}
            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };
            //sayiList.Add(sayilar);//hata verir dizi yapısının elemanlarını göndermedik diziyi veriğimiz için elemanlarını göremeyiz.
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
            #region ArrayList Method
            //ArrayList list = new ArrayList();
            //list.Add(10);//Tekli ekleme yöntemi 
            //list.AddRange(new ArrayList { 10, 20, 30, 50, 60,10, 70 });//Çoklu ekleme
            //                                                        //Dondur(list);
            //                                                        //!!Insert: istenilen index değerine istenilen elemanı ekler
            //                                                        //list.Insert(0, "Erkan");
            //                                                        // list.InsertRange(1, new ArrayList { "Hakan", "Emre", "Onur", "Furkan" });//Çoklu insert işlemi
            //                                                        //Dondur(list);
            //                                                        //Dondur(list);
            //                                                        //Clear:Temizleme
            //                                                        //list.Clear();
            //                                                        //Dondur(list);
            //                                                        //Remove silme:
            //                                                        //list.Remove(20);//Value üzerinden silme işlemi yapar
            //                                                        // Dondur(list);
            //                                                        //list.RemoveAt(3);//istenilen indexdeki değeri siler
            //                                                        //list.RemoveRange(1, 3);//istenilen indexden başlayıp verdiğimiz uzunluğa göre siler

            ////Dondur(list);
            ////IndexOf arama yapısı
            //Console.WriteLine(list.IndexOf(10));//verdiğimiz value değeri hangi indexde bulur
            //Console.WriteLine(list.IndexOf(10,2));//verdiğimiz value değeri hangi indexde bulur
            //Console.WriteLine(list.LastIndexOf(10,5));//sondan başlayıp verdiğim indexden aramaya başlar ilk bulduğu değeri getirir.
            //list.Reverse();//tersine çevirir

            //list.Sort();//küçükten büyüğe sıralar fakat arraylist yapısında tek veri tipi olmalıdır.
            //Dondur(list);

            //Console.WriteLine(list.Contains(10));//içerisinde istediğim değer var mı ?

            //ArrayList arrayList = new ArrayList() { 5, 15, "Test", "25", 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(arrayList.Contains("25")?"Var":"Yok");//? if : Else 
            //ArrayList array = (ArrayList)arrayList.Clone();//Dolu bir arraylisti boş arrayliste aktarma
            //Dondur(array);

            //!!Kullanıcıdan sayı isteyelim Sayı verdiği sürece 
            //sayı girsin sayı yerine Q ya basarsa girilen tüm sayıları toplasın ve ekrana yazdırsın
            //ArrayList list = new ArrayList();
            //int toplam = 0;
            //for (int i = 0; i <=list.Count; )
            //{

            //}
            ArrayList list = new ArrayList();
            int toplam = 0;

            for(int i = 0; i <= list.Count;)
{
                Console.WriteLine("Sayi girin:");
                string sayi = Console.ReadLine().ToUpper();
                if (sayi == "Q")
                {
                    break;

                }
                int deger = Convert.ToInt32(sayi);
                list.Add(deger);
                toplam += deger;


            }
            Console.WriteLine(toplam);
            Console.WriteLine("**************");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        public static void Dondur(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}

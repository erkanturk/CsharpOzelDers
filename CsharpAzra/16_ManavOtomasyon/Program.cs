using System.Collections;

namespace _16_ManavOtomasyon
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
            ArrayList halMeyveler = new ArrayList() { "ELMA", "ARMUT", "KARPUZ", "PORTAKAL", "KAVUN" };
            ArrayList halSebzeler = new ArrayList() { "DOMATES", "BİBER", "PATLICAN", "PATATES", "SOĞAN" };
            ArrayList manavMeyve = new ArrayList();
            ArrayList manavMeyveKilo = new ArrayList();
            ArrayList manavSebze = new ArrayList();
            ArrayList manavSebzeKilo = new ArrayList();
            ArrayList musteri = new ArrayList();

            Console.WriteLine("**** ŞAKAK HALE HOŞGELDİNİZ ****");
            while (true)
            {
                Console.WriteLine("Meyve mi ? Sebze mi ? (M/S) Çıkış için Q ya basınız");
                string halSecim = Console.ReadLine().ToUpper();
                if (halSecim=="M")
                {
                    try
                    {
                        Console.WriteLine("1-Elma\n2-Armut\n3-Karpuz\n4-Portakal\n5-Kavun");
                        string meyve = Console.ReadLine().ToUpper();
                        int meyve2;
                        if (int.TryParse(meyve, out meyve2))
                        {
                            if (meyve2==1)
                            {
                                UrunAl(manavMeyve, "ELMA", manavMeyveKilo);
                            }
                            else if (meyve2==2)
                            {
                                UrunAl(manavMeyve, "ARMUT", manavMeyveKilo);
                            }
                            else if (meyve2==3)
                            {
                                UrunAl(manavMeyve, "KARPUZ", manavMeyveKilo);
                            }
                            else if (meyve2==4)
                            {
                                UrunAl(manavMeyve, "PORTAKAL", manavMeyveKilo);
                            }
                            else if (meyve2==5)
                            {
                                UrunAl(manavMeyve, "KAVUN", manavMeyveKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                            }

                        }
                        else
                        {
                            if (meyve=="ELMA")
                            {
                                UrunAl(manavMeyve, "ELMA", manavMeyveKilo);
                            }
                            else if (meyve=="ARMUT")
                            {
                                UrunAl(manavMeyve, "ARMUT", manavMeyveKilo);
                            }
                            else if (meyve=="KARPUZ")
                            {
                                UrunAl(manavMeyve, "KARPUZ", manavMeyveKilo);
                            }
                            else if (meyve=="PORTAKAL")
                            {
                                UrunAl(manavMeyve, "PORTAKAL", manavMeyveKilo);
                            }
                            else if (meyve=="KAVUN")
                            {
                                UrunAl(manavMeyve, "KAVUN", manavMeyveKilo);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı seçim");
                                Thread.Sleep(2000);
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("Başka bir arzunuz var mı ? (E/H)");
                        string cevap = Console.ReadLine().ToUpper();
                        if (cevap=="E")
                        {
                            continue;
                        }
                        else if (cevap=="H")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama");
                            Thread.Sleep(3000);
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hata: "+ex.Message);
                    }
                }
                else if (halSecim=="S")
                {
                    Console.WriteLine("1-Domates\n2-Biber\n3-Patlıcan\n4-Patates\n5-Soğan");
                    string sebze = Console.ReadLine().ToUpper();
                    int sebze2;
                    if (int.TryParse(sebze, out sebze2))
                    {
                        if (sebze2==1)
                        {
                            UrunAl(manavSebze, "DOMATES", manavSebzeKilo);
                        }
                        else if (sebze2==2)
                        {
                            UrunAl(manavSebze, "BİBER", manavSebzeKilo);
                        }
                        else if (sebze2==3)
                        {
                            UrunAl(manavSebze, "PATLICAN", manavSebzeKilo);
                        }
                        else if (sebze2==4)
                        {
                            UrunAl(manavSebze, "PATATES", manavSebzeKilo);
                        }
                        else if (sebze2==5)
                        {
                            UrunAl(manavSebze, "SOĞAN", manavSebzeKilo);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                            Thread.Sleep(2000);
                        }

                    }
                    else
                    {
                        if (sebze=="DOMATES")
                        {
                            UrunAl(manavSebze, "DOMATES", manavSebzeKilo);
                        }
                        else if (sebze=="BİBER")
                        {
                            UrunAl(manavSebze, "BİBER", manavSebzeKilo);
                        }
                        else if (sebze=="PATLICAN")
                        {
                            UrunAl(manavSebze, "PATLICAN", manavSebzeKilo);
                        }
                        else if (sebze=="PATATES")
                        {
                            UrunAl(manavSebze, "PATATES", manavSebzeKilo);
                        }
                        else if (sebze=="SOĞAN")
                        {
                            UrunAl(manavSebze, "SOĞAN", manavSebzeKilo);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı seçim");
                            Thread.Sleep(2000);
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Başka bir arzunuz var mı ? (E/H)");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap=="E")
                    {
                        continue;
                    }
                    else if (cevap=="H")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama");
                        Thread.Sleep(3000);
                    }

                }
                else if (halSecim=="Q")
                {
                    Console.WriteLine("Yine bekleriz");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim");
                    Thread.Sleep(2000);
                }
            }
            while (true)
            {
                Console.WriteLine("Azra Manava Hoşgeldiniz");
                Console.WriteLine("Meyve mi ? Sebze mi ? (M/S)");
                string manavSecim = Console.ReadLine().ToUpper();
                if (manavSecim=="M")
                {
                    if (manavMeyve.Count==0)
                    {
                        Console.WriteLine("Meyveler Tükenmiştir.");
                        continue;
                    }
                    for (int i = 0; i<manavMeyve.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {manavMeyve[i]}-{manavMeyveKilo[i]} kilo mevcut ");
                    }
                    try
                    {
                        Console.WriteLine("Ürün seçiniz");
                        string input = Console.ReadLine().ToUpper();
                        string meyve = "";
                        int meyveNo;
                        if (int.TryParse(input, out meyveNo))
                        {
                            if (meyveNo>=1&&meyveNo<=manavMeyve.Count)
                            {
                                meyve=manavMeyve[meyveNo-1].ToString();

                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                continue;
                            }
                        }
                        else
                        {
                            meyve=input;
                            if (!manavMeyve.Contains(meyve))
                            {
                                Console.WriteLine("Olmayan ürün");
                                continue;
                            }
                        }
                        if (manavMeyve.Contains(meyve))
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavMeyve.IndexOf(meyve);
                            int meyveKilo = (int)manavMeyveKilo[index];
                            if (meyveKilo>=kilo)
                            {
                                meyveKilo-=kilo;
                                musteri.Add($"{meyve}-{kilo}");
                                manavMeyveKilo[index]=meyveKilo;
                                if (meyveKilo==0)
                                {
                                    manavMeyve.RemoveAt(index);
                                    manavMeyveKilo.RemoveAt(index);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"İstenilen kilo mevcut değil {meyve}-{meyveKilo} kilo mevcut");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün");
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Hatalı işlem:"+ex.Message);
                        Thread.Sleep(3000);
                    }
                    Console.WriteLine("Başka bir arzunuz var mı (E/H)?");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap=="E")
                    {
                        continue;
                    }
                    else if (cevap=="H")
                    {
                        Console.WriteLine("İyi günler");
                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı tyuşlama");
                    }

                }
                else if (manavSecim=="S")
                {
                    if (manavSebze.Count==0)
                    {
                        Console.WriteLine("Sebzeler Tükenmiştir");
                        continue;
                    }
                    for (int i = 0; i<manavSebze.Count; i++)
                    {
                        Console.WriteLine($"{i + 1} - {manavSebze[i]}-{manavSebzeKilo[i]} kilo mevcut ");
                    }
                    try
                    {
                        Console.WriteLine("Ürün seçiniz");
                        string input = Console.ReadLine().ToUpper();
                        string sebze = "";
                        int sebzeNo;
                        if (int.TryParse(input, out sebzeNo))
                        {
                            if (sebzeNo>=1&&sebzeNo<=manavSebze.Count)
                            {
                                sebze=manavSebze[sebzeNo-1].ToString();

                            }
                            else
                            {
                                Console.WriteLine("Hatalı Seçim");
                                continue;
                            }
                        }
                        else
                        {
                            sebze=input;
                            if (!manavSebze.Contains(sebze))
                            {
                                Console.WriteLine("Olmayan ürün");
                                continue;
                            }
                        }
                        if (manavSebze.Contains(sebze))
                        {
                            Console.WriteLine("Kaç kilo");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            int index = manavSebze.IndexOf(sebze);
                            int sebzeKilo = (int)manavSebzeKilo[index];
                            if (sebzeKilo>=kilo)
                            {
                                sebzeKilo-=kilo;
                                musteri.Add($"{sebze}-{kilo}");
                                manavSebzeKilo[index]=sebzeKilo;
                                if (sebzeKilo==0)
                                {
                                    manavSebze.RemoveAt(index);
                                    manavSebzeKilo.RemoveAt(index);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"İstenilen kilo mevcut değil {sebze}-{sebzeKilo} kilo mevcut");
                                Thread.Sleep(2000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Olmayan ürün");
                        }
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Hatalı işlem");
                    }
                    Console.WriteLine("Başka bir arzunuz var mı (E/H)?");
                    string cevap = Console.ReadLine().ToUpper();
                    if (cevap=="E")
                    {
                        continue;
                    }
                    else if (cevap=="H")
                    {
                        Console.WriteLine("İyi günler");
                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı tyuşlama");
                    }

                }
            }
           foreach (var i in musteri)
            {
                Console.WriteLine(i);
            }

        }
        static void UrunAl(ArrayList list, string urun, ArrayList kiloList)
        {
            if (list.Contains(urun)==false)
            {
                list.Add(urun);
                Console.WriteLine("Kaç kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                kiloList.Add(kilo);
            }
            else
            {
                Console.WriteLine("Kaç kilo");
                int kilo = Convert.ToInt32(Console.ReadLine());
                int index = list.IndexOf(urun);
                int meyveKilo = (int)kiloList[index];
                meyveKilo+=kilo;
                kiloList[index]=meyveKilo;
            }
        }
    }
}

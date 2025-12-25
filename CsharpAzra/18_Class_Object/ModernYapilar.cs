using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Class_Object
{
    internal class ModernYapilar
    {
    }
    #region RecordTipi
    /* Record(Kayıt Tipi)
     * Değer odaklı,değiştirilemez(immutable) veri yapısıdır.
     * Otomatik olarak Equals,GetHashCode,ToString methodlarını oluşturur
     * Veri transfer nesneleri (DTO) için idealdir.
     * "with" ifadesi ile kopyalama yapılabilir
     
     */
    //Basit record tanımı tek satırda sınıf oluşturma
    public record Personel(string Ad, string Soyad, int yas);

    public record Musteri
    {
        //init:Sadece nesne oluşturulurken değer atanabili sonrasında değiştirilemez.
        public required string MusteriAd { get; init; }
        public required string MusteriSoyad { get; init; }
        public string? Adres { get; init; }//? işareti: Bu alan null bırakılabilir.
    }

    #endregion
    #region Struct tipi
    /* Struct(Yapı):
     * Deper tipidir stack bellekte saklanır (class referans tipidir heap'te saklanır)
     * küçük veri gurupları için idealdir
     * new ile oluşturulamazsa varsayılan değerler atanır.
     */
    public struct Dikdortgen
    {
        public int Genislik { get; init; }
        public int Yukseklik { get; init; }

        //readonly:Bu method yapıyı değiştirmez
        public readonly int AlanHesapla() => Genislik*Yukseklik;
    }

    public class NullKontrolOrnekleri
    {
        public static void KontrolYap(string? deger)
        {
            if (deger is not null)//=> !=null
            {
                Console.WriteLine($"değer {deger}");
            }
            if (deger is null)
            {
                Console.WriteLine("Değer boş");
            }
            //?? operatörü: null ise varsayılan değeri kullan

            string sonuc = deger??"Varsayılan";
            Console.WriteLine(sonuc);

            int? uzunluk = deger?.Length;
            Console.WriteLine($"Uzunluk {uzunluk??0}");

        }
    }
    #endregion
}

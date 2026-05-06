using _34_Ado.Net.Data;
using _34_Ado.Net.Models;
using Microsoft.Data.SqlClient;

namespace _34_Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ado.Net Sql bağlantı yapısıdır
             * Database first mantığı ile çalışır 
             * İçerisinde sql injection ve using kavramı ile veri tabanına komutlar gönderilip veri tabanından veriler çekme 
             * işlemi yapılır 
             * bu yapıda var olan database yada sıfır oluşturulan database yapısı kullanılır
             * Şimdiki senaryomuz 
             * Bir öğretmen sınıfımız olacak bu sınıf yapısı aynı şekilde veritabanında da olması gerekiyor 
             * ve bu öğretmen sınıfımız veritabanında bulunan tablo yapımızı temsil edecek içerisinde
             * bulunan property yapıları ise tablonun sütunları olarak kullanılacak.
             */

            DataContext dataContext = new DataContext();
            // dataContext.OgretmenEkle();
            Ogretmen ogretmen = new Ogretmen();
            Console.WriteLine("Ad:");
            ogretmen.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            ogretmen.Soyad = Console.ReadLine();
            Console.WriteLine("Branş:");
            ogretmen.Brans = Console.ReadLine();
            Console.WriteLine("Yaş");
            ogretmen.Yas = Convert.ToInt32(Console.ReadLine());
            //dataContext.OgretmenEkle(ogretmen);

            //Console.WriteLine("Aradığın öğretmenin adı");
            //string ad = Console.ReadLine();
            Console.WriteLine("Öğretmen no");
            int id = Convert.ToInt32(Console.ReadLine());
            dataContext.Update(ogretmen.Ad,ogretmen.Soyad,ogretmen.Brans,ogretmen.Yas, id);
            SqlDataReader reader = dataContext.Listele();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString());
                Console.WriteLine(reader[1].ToString());
                Console.WriteLine(reader[2].ToString());
                Console.WriteLine(reader[3].ToString());
                Console.WriteLine(reader[4].ToString());
            }

            //Console.WriteLine("Silmek istediğin Öğretmen numarası");
            //int id = Convert.ToInt32(Console.ReadLine());
            //dataContext.Delete(id);

            //SqlDataReader reader2 = dataContext.Listele();
            //while (reader2.Read())
            //{
            //    Console.WriteLine(reader2[0].ToString());
            //    Console.WriteLine(reader2[1].ToString());
            //    Console.WriteLine(reader2[2].ToString());
            //    Console.WriteLine(reader2[3].ToString());
            //    Console.WriteLine(reader2[4].ToString());
            //}

        }
    }
}

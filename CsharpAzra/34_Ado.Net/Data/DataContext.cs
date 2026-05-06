using _34_Ado.Net.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Ado.Net.Data
{
    public class DataContext
    {
        private readonly SqlConnection con;
        public DataContext()
        {
            con = new SqlConnection(@"Data Source=204-HOCAPC1;Initial Catalog=OkulDb;Persist Security Info=True;User ID=sa;Password=1;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""SQL Server Management Studio"";Command Timeout=0");

        }

        public int OgretmenEkle()
        {
            var eks = 0;
            try
            {
                //Sql sorgusu backend tarafından veritabanında çalışacak sorgu
                SqlCommand cmd = new SqlCommand($"Insert into Ogretmen(Ad,Soyad,Brans,Yas) values('Erkan','Türk','Yazılım','32')", con);

                con.Open();//Sql bağlantısını aç
                eks = cmd.ExecuteNonQuery();//Sorguyu gönder
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata" + ex.Message);
            }
            finally
            {
                con.Close();//hata olsada olmasada bağlantıyı kapat
            }
            return eks;
        }
        public void OgretmenEkle(Ogretmen ogretmen)
        {
            
            try
            {
                //Sql sorgusu backend tarafından veritabanında çalışacak sorgu
                SqlCommand cmd = new SqlCommand($"Insert into Ogretmen(Ad,Soyad,Brans,Yas) values('{ogretmen.Ad}','{ogretmen.Soyad}','{ogretmen.Brans}','{ogretmen.Yas}')", con);

                con.Open();//Sql bağlantısını aç
                cmd.ExecuteNonQuery();//Sorguyu gönder
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata" + ex.Message);
            }
            finally
            {
                con.Close();//hata olsada olmasada bağlantıyı kapat
            }

        }
        public SqlDataReader Listele()
        {
            SqlDataReader reader;
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Ogretmen", con);
                con.Open();
                reader = cmd.ExecuteReader();
                return reader;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
               
            }
            
        }
        public SqlDataReader Listele(string ad)
        {
            SqlDataReader reader;
            try
            {
                SqlCommand cmd = new SqlCommand($"Select * from Ogretmen where Ad like '%{ad}%'", con);
                con.Open();
                reader = cmd.ExecuteReader();
                return reader;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //con.Close();
            }

        }
        public void Delete(int id)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand();
            if (id == null)
            {
                Console.WriteLine("Id parametresi geçrsiz");
            }
            else
            {
                cmd = new SqlCommand($"Delete from Ogretmen where Id={id}", con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        public void Update(string ad, string soyad, string brans, int yas ,int id)
        {
            
            try
            {
                //Sql sorgusu backend tarafından veritabanında çalışacak sorgu
                SqlCommand cmd = new SqlCommand($"Update Ogretmen set Ad=@ad,Soyad=@soyad,Brans=@brans,Yas=@yas where Id=@id", con);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@brans", brans);
                cmd.Parameters.AddWithValue("@yas", yas);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();//Sql bağlantısını aç
                cmd.ExecuteNonQuery();//Sorguyu gönder
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata" + ex.Message);
            }
            finally
            {
                con.Close();//hata olsada olmasada bağlantıyı kapat
            }
        }

    }
}

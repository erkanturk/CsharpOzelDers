namespace _28_Partial_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Parçalı sınıf fiziksel olarak Personel ve Personel1 olarak 2 farklı sınıf yapısı oluşturup
             * 2 class yapısınında ismini Personel olarak belirtiyoruz normalde bu durum hata verir fakat
             * Partial keyword'ü ile bu sınıflar bir bütünün parçası olarak çalışırlar yani
             * Sistem ayağa kalkarken bu yapılar tek bir sınıf gibi görür iki sınıf tek bir sınıf gibi kullanarak
             * Büyük mimari yapılarda daha performanslı çalışmasını ve iki sınıftaki öğelerin tek bir yapı ile kontrol edile bilmesine olanak tanır.
             
             */

            Personel personel = new Personel();
            personel.IsimKaydet();
            personel.AdresBilgileri();
            string tel = personel.PhoneKaydet();

            Console.WriteLine($"Ad:{personel.Name} Adres:{personel.Address}/{personel.City} Telefon:{tel}");
        }
    }
}

namespace _29_OOP_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* BankaSistem adında bir sınıfımız olacak 
             * Bu sınıfta Para gönder adında bir iş yapan method olacak virtual yapıda int parametre alan
             * Havale 
             * Swift 
             * Eft diye sınıflarımız olacak 
             * Banka sisteminden gelen para gönderme işlemlerini her sınıf kendi yapısı ile 
             * Kullanarak İşlem gerçekleştirecek 
             * Havale örneğin base yapısı ile Havale işlemi yapacak gelen tutarı
             * Swift swift işlemi yapacak gelen tutarı
             * bu değerler ekranda havale eft swift yapıldı ve tutarla birlikte override edilerek görünecek
            
            */
            Canli canli = new Canli();
            canli.HareketEt();
            canli = new Balik();
            canli.HareketEt();
            canli = new Kus();
            canli.HareketEt();
            canli = new Insan();
            canli.HareketEt();
            canli = new Yilan();
            canli.HareketEt();
        }
    }
}

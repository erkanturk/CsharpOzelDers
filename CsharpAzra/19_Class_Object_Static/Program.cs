namespace _19_Class_Object_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static nonStatic User
            List<User> users = new List<User>();



            User.Kaydet(users);//Static yapı
            foreach (var item in users)
            {
                Console.WriteLine(item.Name+" "+item.SurName+" "+item.UserName+" "+item.Password);
            }
            User user = new User();//NonStatic
            user.Kaydet(user);
            Console.WriteLine();//Static
            Random random = new Random();//Nonstatic

            user.Kaydet3("erkan", "türk", "erkantrk", "1453");
            double sayi = 123;
            int sayi2 = sayi;
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Class_Object_Static
{
    internal class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public static void Kaydet(List<User> users)
        {
            User user = new User();
            Console.WriteLine("Ad:");
            user.Name=Console.ReadLine();
            Console.WriteLine("Soyad:");
            user.SurName=Console.ReadLine();
            Console.WriteLine("Kullanıcı Adı:");
            user.UserName=Console.ReadLine();
            Console.WriteLine("Şifre:");
            user.Password=Console.ReadLine();

            users.Add(user);

        }

        public void Kaydet(User user)
        {

            Console.WriteLine("Ad:");
            user.Name=Console.ReadLine();
            Console.WriteLine("Soyad:");
            user.SurName=Console.ReadLine();
            Console.WriteLine("Kullanıcı Adı:");
            user.UserName=Console.ReadLine();
            Console.WriteLine("Şifre:");
            user.Password=Console.ReadLine();

            Console.WriteLine($"Ad {user.Name} Soyad {user.SurName} Kullanıcı Adı {user.UserName}");

        }
        public void Kaydet2(List<User> lists)
        {
            Console.WriteLine("Ad:");
            Name=Console.ReadLine();
            Console.WriteLine("Soyad:");
            SurName=Console.ReadLine();
            Console.WriteLine("Kullanıcı Adı:");
            UserName=Console.ReadLine();
            Console.WriteLine("Şifre:");
            Password=Console.ReadLine();

            lists.Add(this);//this o anki sınıfın özelliklerini kullanmanı sağlar.
        }
        public void Kaydet3(string Name, string SurName, string UserName, string Password)
        {
            this.Name=Name;//aynı isme sahip değerleri kullanırken this keywordu
                           //o sınıfın özellikleri ile parametreyi birbirinden ayırmamızı sağlar
            this.SurName=SurName;
            this.UserName=UserName;
            this.Password=Password;
            Console.WriteLine($"Ad {this.Name} Soyad {this.SurName} Kullanıcı Adı {this.UserName}");
        }
    }
}

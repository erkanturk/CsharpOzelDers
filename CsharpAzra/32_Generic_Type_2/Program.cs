namespace _32_Generic_Type_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new BaseClass<char>().Value= 'a';
            new ChildClass().Value = "string";
            new ChildClass().Deger = 'A';
            new ChildClass2<double>().Value = 1.123;
            new ChildClass2<char>().Test = 'A';

            ChildClass2<bool> childClass2 = new ChildClass2<bool>();
            childClass2.Value= true;
            childClass2.Test= false;

            ChildClass3<DateTime> childClass3 = new ChildClass3<DateTime>();
            childClass3.Value = 123;//Sınıf tanımlanırken sadece int değer alacağını belirttik
            childClass3.Test2 = DateTime.Now;

            List<string> strings = new List<string>();
            List<double> doubles = new List<double>();
           


        }
    }
    class BaseClass<T>
    {
        public T Value { get; set; }//Child class kullanırken bu alan string olacak.
    }
    class ChildClass : BaseClass<string>
    {
        public char Deger { get; set; }//Generic bir sınıf olmadığı için içerisinde tanımlanan yapılar belirtilmeli
    }
    class ChildClass2<T> : BaseClass<T>//Sınıf generic olduğu için sınıfın Instance'ı alınırken T değerleri belirtilecek
    {
        public T Test { get; set; }
    }
    class ChildClass3<T> : BaseClass<int>//BaseClass da bulunan value property si sadece int değer alabilir.
    {
        public T Test2 { get; set; }
    }
}

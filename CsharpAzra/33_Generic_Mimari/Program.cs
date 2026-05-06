using _33_Generic_Mimari.DataAccess.Concrete;
using _33_Generic_Mimari.Entities;

namespace _33_Generic_Mimari
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product products = new Product()
            {
                Id= 1,
                Name="Test",
                Description="Deneme",
                Price=123
            };
            ProductDal product = new ProductDal();
            
            product.Create(products);
        }
    }
}

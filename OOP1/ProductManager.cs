using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        //Encapsulation
        public static void Add(Product product)
        {
            Console.WriteLine($"{product.ProductName} adli mehsul elave olundu!");
        }

        public static void Update(Product product)
        {
            Console.WriteLine($"{product.ProductName} adli mehsul yenilendi!");
        }

        public static void Delete(Product product)
        {
            Console.WriteLine($"{product.ProductName} adli mehsul silindi!");
        }
    }
}

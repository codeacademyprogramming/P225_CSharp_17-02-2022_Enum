using P225ClassWork.Enums;
using P225ClassWork.Models;
using System;

namespace P225ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsulun Adini Daxil Et:");
            string name = Console.ReadLine();

            Console.WriteLine("Mehsulun Qiymetini Daxil Et:");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Mehsulun Novunu Sec:");
            foreach (var item in Enum.GetValues(typeof(ProductType)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }

            int selected = int.Parse(Console.ReadLine());

            ProductType productType = 0;

            switch (selected)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    productType = (ProductType)selected;
                    break;
                default:
                    break;
            }

            Product product = new Product(productType, price);
            product.Name = name;

            Product product1 = new Product(ProductType.Drink, 15);
            product1.Name = name;

            Product product2 = new Product(ProductType.Fish, 50);
            product2.Name = name;

            Product product3 = new Product(ProductType.Meat, 50);
            product3.Name = name;

            Console.WriteLine($"{product._code} {product.ProductType} {product.Name} {product.Price} {product.DiscountPrice}");
            Console.WriteLine($"{product1._code} {product1.ProductType} {product1.Name} {product1.Price} {product1.DiscountPrice}");
            Console.WriteLine($"{product2._code} {product2.ProductType} {product2.Name} {product2.Price} {product2.DiscountPrice}");
            Console.WriteLine($"{product3._code} {product3.ProductType} {product3.Name} {product3.Price} {product3.DiscountPrice}");


            Console.WriteLine(Product._totalCount);
        }
    }
}

using P225ClassWork.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225ClassWork.Models
{
    class Product
    {
        private static int _count = 1000;
        public readonly string _code;
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }
        public ProductType ProductType { get; set; }
        public static int _totalCount;

        public Product(ProductType productType, double price)
        {
            _count++;
            _totalCount++;
            _code = $"{productType.ToString()[0]}{_count}";
            Price = price;
            if (productType == ProductType.Bakery)
            {
                DiscountPrice = price - (price * 0.1);
            }
            ProductType = productType;
        }

    }
}

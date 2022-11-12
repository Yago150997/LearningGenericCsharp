using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace HigherPriceProduct.Entities
{
    class Product : IComparable
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product()
        {

        }

        public Product(string productName, double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }

            Product other = obj as Product;

            return ProductPrice.CompareTo(other.ProductPrice);
        }

        public override string ToString()
        {
            return ProductName +

                ", " +
                ProductPrice.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

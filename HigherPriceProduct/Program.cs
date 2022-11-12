using HigherPriceProduct.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HigherPriceProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter number of products ");
            
            Console.Write("Answer: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digit the product's name and price: ");
                string[] NameandPrice = Console.ReadLine().Split(",");
                double price = double.Parse(NameandPrice[1], CultureInfo.InvariantCulture);

                list.Add(new Product(NameandPrice[0], price));
            }

            CalculationService calculation = new CalculationService();

            Product p = calculation.Max(list);

            Console.Write("Most expensive product is: ");
            Console.WriteLine(p);
        }
    }
}

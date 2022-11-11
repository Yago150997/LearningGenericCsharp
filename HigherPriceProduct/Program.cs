using HigherPriceProduct.Entities;
using System;
using System.Collections.Generic;

namespace HigherPriceProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("How many Numbers? ");
            
            Console.Write("Answer: ");
            int N = int.Parse(Console.ReadLine());

            CalculationService calculation = new CalculationService();

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digit a number: ");
                int number = int.Parse(Console.ReadLine());

                list.Add(number);
            }

            Console.WriteLine("Higher number is: " + calculation.Max(list));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace P7SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> salesBytown = new SortedDictionary<string, double>();

            for (int i = 0; i < inputCount; i++)
            {
                Sale sale = ReadSales();

                string townName = sale.Town;
                double sum = sale.Price * sale.Quantity;

                if (salesBytown.ContainsKey(townName) == false)
                {
                    salesBytown.Add(sale.Town, sum);
                }
                else
                {
                    salesBytown[townName] += sum;
                }
            }

            foreach (var town in salesBytown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:F2}");
            }
        }

        static Sale ReadSales()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            Sale sale = new Sale();
            sale.Town = input[0];
            sale.Product = input[1];
            sale.Price = double.Parse(input[2]);
            sale.Quantity = double.Parse(input[3]);

            return sale;
        }

        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public double Price { get; set; }
            public double Quantity { get; set; }
        }
    }
}

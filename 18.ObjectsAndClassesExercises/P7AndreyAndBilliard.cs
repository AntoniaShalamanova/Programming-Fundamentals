using System;
using System.Collections.Generic;
using System.Linq;

namespace P7AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int productsNumber = int.Parse(Console.ReadLine());
            Dictionary<string, double> ourShop = new Dictionary<string, double>();
            string input = "";

            for (int i = 0; i < productsNumber; i++)
            {
                input = Console.ReadLine();
                string productName = input.Split('-')[0];
                double productPrice = double.Parse(input.Split('-')[1]);

                if (ourShop.ContainsKey(productName) == false)
                {
                    ourShop.Add(productName, productPrice);
                }
                else
                {
                    ourShop[productName] = productPrice;
                }
            }

            List<Customer> customers = new List<Customer>();
            input = Console.ReadLine();

            while (input != "end of clients")
            {
                string customerName = input.Split(new char[] { '-', ',' })[0];
                string wantedProduct = input.Split(new char[] { '-', ',' })[1];
                int quantity= int.Parse(input.Split(new char[] { '-', ',' })[2]);

                if (ourShop.ContainsKey(wantedProduct))
                {
                    if (customers.Exists(x => x.Name == customerName))
                    {
                        int objIndx = customers.FindIndex(x => x.Name == customerName);

                        if (customers[objIndx].ShopList.ContainsKey(wantedProduct))
                        {
                            customers[objIndx].ShopList[wantedProduct] += quantity;
                            customers[objIndx].Bill += quantity * ourShop[wantedProduct];
                        }
                        else
                        {
                            customers[objIndx].ShopList.Add(wantedProduct, quantity);
                            customers[objIndx].Bill += quantity * ourShop[wantedProduct];
                        }
                    }
                    else
                    {
                        var wantedProductAndQuantity = new Dictionary<string, double>();
                        wantedProductAndQuantity.Add(wantedProduct, quantity);

                        Customer customer = new Customer();
                        customer.Name = customerName;
                        customer.ShopList = wantedProductAndQuantity;
                        customer.Bill = quantity * ourShop[wantedProduct];

                        customers.Add(customer);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine($"Total bill: {customers.Sum(x => x.Bill):F2}");
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }
}

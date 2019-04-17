using System;
using System.Linq;
using System.Numerics;

namespace P1AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int websitesNumber = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());

            string[] affectedWebsites = new string[websitesNumber];
            decimal totalLoss = 0;
            BigInteger securityToken = BigInteger.Pow(securityKey, websitesNumber);

            for (int i = 0; i < websitesNumber; i++)
            {
                string[] websiteData = Console.ReadLine().Split(' ').ToArray();

                string siteName = websiteData[0];
                long siteVisits = long.Parse(websiteData[1]);
                decimal pricePerVisit = decimal.Parse(websiteData[2]);

                affectedWebsites[i] = siteName;
                totalLoss += siteVisits * pricePerVisit;
            }

            foreach (string site in affectedWebsites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}

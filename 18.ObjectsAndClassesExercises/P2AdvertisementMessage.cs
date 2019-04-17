using System;

namespace P2AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int messagesNumber = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events =
             {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            string[] authors =
                 {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            string[] cities =
                 {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random randIndex = new Random();

            for (int i = 0; i < messagesNumber; i++)
            {
                string randPhrase = phrases[randIndex.Next(0, phrases.Length)];
                string randEvent = events [randIndex.Next(0, events.Length)];
                string randAuthor = authors[randIndex.Next(0, authors.Length)];
                string randCity = cities[randIndex.Next(0, cities.Length)];

                Console.WriteLine($"{randPhrase} {randEvent} {randAuthor} - {randCity}");
            }
        }
    }
}

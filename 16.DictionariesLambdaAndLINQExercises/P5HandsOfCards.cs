using System;
using System.Linq;
using System.Collections.Generic;

namespace P5HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> playersCards = new Dictionary<string, List<string>>();
            List<string> cards = new List<string>();

            char[] separators = { ':', ',' };
            string[] hand = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (hand[0] != "JOKER")
            {
                string name = hand[0];
                cards = hand.Skip(1).ToList();

                cards = cards.Select(x => x.Trim().ToString()).ToList();

                if (playersCards.ContainsKey(name) == false)
                {
                    playersCards.Add(name, cards);
                }
                else
                {
                    playersCards[name].AddRange(cards);
                }

                hand = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            playersCards = playersCards.ToDictionary(x => x.Key, x => x.Value.Distinct().ToList());


            foreach (var player in playersCards)
            {
                int sum = 0;

                foreach (var card in player.Value)
                {
                    int powerPoints = 0;
                    int typePoints = 0;

                    string cardPower = card.Remove(card.Length - 1, 1);
                    char cardType = card.Last();

                    switch (cardPower)
                    {
                        case "J":
                            powerPoints = 11;
                            break;
                        case "Q":
                            powerPoints = 12;
                            break;
                        case "K":
                            powerPoints = 13;
                            break;
                        case "A":
                            powerPoints = 14;
                            break;
                        default:
                            powerPoints = int.Parse(cardPower);
                            break;
                    }

                    switch (cardType)
                    {
                        case 'S':
                            typePoints = 4;
                            break;
                        case 'H':
                            typePoints = 3;
                            break;
                        case 'D':
                            typePoints = 2;
                            break;
                        case 'C':
                            typePoints = 1;
                            break;
                    }

                    sum += powerPoints * typePoints;
                }

                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}
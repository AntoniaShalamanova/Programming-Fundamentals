﻿using System;

namespace P15NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            int healthPesho = 100;
            int healthGosho = 100;

            int round = 0;

            while (true)
            {
                round++;

                if (round % 2 != 0)
                {
                    healthGosho -= damagePesho;
                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else
                {
                    healthPesho -= damageGosho;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }


                if (round % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
            }
        }
    }
}

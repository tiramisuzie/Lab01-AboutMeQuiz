﻿using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GuessDessert());
            Console.WriteLine(GuessDay() == 28 ? "Correct" : "Incorrect, I was born on the 28th");
            
        }

        static string GuessDessert()
        {
            Console.WriteLine("What is my favorite dessert?");
            string guess = Console.ReadLine();

            if (guess == "tiramisu" || guess == "panna cotta")
            {
               return "Correct!";
            }
            else 
            {
                return "Incorrect, my favorite dessert is tiramisu and panna cotta";
            }


        }

        static int GuessDay()
        {
            Console.WriteLine('What day of the month was I born?');
            int guess = int.Parse(Console.ReadLine());

            return guess;
        }

        static string GuessTravel()
        {
            Console.WriteLine("What is my favorite place to travel to?");
            string guess = Console.ReadLine();

            if (guess == "Japan")
            {
                return "correct";
            }
        }
    }
}

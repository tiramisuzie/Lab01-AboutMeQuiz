using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GuessDessert());
            
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
            Console.WriteLine('What day of the month was I born?')

        }
    }
}

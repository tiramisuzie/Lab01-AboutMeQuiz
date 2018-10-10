using System;

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GuessDessert());
            Console.WriteLine(GuessDay() == 28 ? "Correct" : "Incorrect, I was born on the 28th");
            Console.WriteLine(GuessAnimals() ? "Correct" : "Incorrect, I love animals");
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
            string guess = Console.ReadLine();
            if (guess == "28")
            {
                return 28;
            }
            return 0;
        }

        static string GuessTravel()
        {
            Console.WriteLine("What is my favorite place to travel to?");
            string guess = Console.ReadLine();

            if (guess == "Japan")
            {
                return "correct";
            } 
            else
            {
                return "that sounds like a great place to travel too! Currently my favorite place to visit is Japan";
            
            }
        }
        static bool GuessAnimals()
        {
            Console.WriteLine("Do I like animals?");
            string guess = Console.ReadLine();

            if (guess == "y" || guess == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

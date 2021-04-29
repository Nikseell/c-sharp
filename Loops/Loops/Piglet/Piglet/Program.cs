using System;

namespace Piglet
{
    class Program
    {
        static int number = 0;
        static int score = 0;
        static Random random = new Random();
        static bool isGameActive = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!\n");
            RollDice();

            while (isGameActive)
            {
                var input = Console.ReadKey();
                Console.WriteLine();

                switch (input.Key)
                {
                    case ConsoleKey.Y:
                        RollDice();
                        break;
                    case ConsoleKey.N:
                        isGameActive = false;
                        Console.WriteLine($"\nYou got {score} points.");
                        break;
                    default:
                        isGameActive = true;
                        break;

                }

            }
        }

        private static void RollDice()
        {
            number = random.Next(1, 7);

            if (number == 1)
            {
                isGameActive = false;
                score = 0;
                Console.WriteLine($"You rolled a {number}!");
                Console.WriteLine($"\nYou got {score} points.");
            }
            else
            {
                Console.WriteLine($"You rolled a {number}!");
                score += number;
                Console.Write("Roll again (y/n)? ");
            }
        }
    }
}

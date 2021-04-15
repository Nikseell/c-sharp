using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            Console.Write("> ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Random rd = new Random();
            int random = rd.Next(1, 101);

            if (random == num)
            {
                Console.WriteLine("You guessed it!  What are the odds?!?");
            }
            else if (num < random)
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of {random}.");
            }
            else if (num > random)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of {random}.");
            }
        }
    }
}

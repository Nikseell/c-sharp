using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first word: ");
            var word = Console.ReadLine();
            Console.Write("Enter second word: ");
            var word1 = Console.ReadLine();
            var wordsLength = 0;
            var maxLength = 30;
            wordsLength = word.Length + word1.Length;
            maxLength = maxLength - word.Length - word1.Length;

            if (wordsLength > 30)
            {
                Console.WriteLine("Cant print, both word length is over 30!");
            }
            else
            {
                Console.Write(word);
                for (int i = 0; i < maxLength; i++)
                {
                    Console.Write(".");
                }
                Console.Write(word1);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}

using System;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            Console.WriteLine("Printing using for:");

            for (int i = 0; i < vowels.Length; i++) {
                Console.Write(vowels[i]);
            }

            Console.WriteLine();
            Console.WriteLine("\nPrinting using foreach:");

            foreach (char vow in vowels)
            {
                Console.Write(vow);
            }
            Console.ReadKey();
        }
    }
}

using System;

/*
 * Write a program called CozaLozaWoza which prints the numbers 1 to 110, 11 numbers per line. The program shall print "Coza" in place of the numbers which are multiples of 3, "Loza" for multiples of 5, "Woza" for multiples of 7, "CozaLoza" for multiples of 3 and 5, and so on. The output shall look like:

1 2 Coza 4 Loza Coza Woza 8 Coza Loza 11 
Coza 13 Woza CozaLoza 16 17 Coza 19 Loza CozaWoza 22 
23 Coza Loza 26 Coza Woza 29 CozaLoza 31 32 Coza
 */
namespace CozaLozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x <= 110; x += 1)
            {
                bool regular = true;
                Console.Write(" ");

                if (x % 3 == 0)
                {
                    Console.Write("Coza");
                    regular = false;
                }

                if (x % 5 == 0)
                {
                    Console.Write("Loza");
                    regular = false;
                }

                if (x % 7 == 0)
                {
                    Console.Write("Woza");
                    regular = false;
                }

                if (regular)
                {
                    Console.Write(x);
                }

                if (x % 11 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

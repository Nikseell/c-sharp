using System;

namespace CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check if number is odd or even\n");
            Console.Write("Input number: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (i % 2 == 0)
            {
                Console.WriteLine("Even Number\n");
            } else
            {
                Console.WriteLine("Odd Number\n");
            }
            Console.WriteLine("Bye!");
        }
    }
}

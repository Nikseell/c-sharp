using System;

namespace NumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Enter how much numbers do you want to count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n");
            for(i = 0; i <= count; i++)
            {
                Console.Write("Enter a number: ");
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
                Console.WriteLine("Sum of numbers is: " + sum + "\n");
            }

        }
    }
}

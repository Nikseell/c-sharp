using System;

namespace TwoInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckNumber();
        }

        public static bool CheckNumber()
        {
            Console.WriteLine("Write two numbers: ");
            Console.Write("First number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Secound number: ");
            int secound = Convert.ToInt32(Console.ReadLine());

            if (first == 15 || secound == 15 || first + secound == 15 || first - secound == 15 || secound - first == 15)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
    }
}

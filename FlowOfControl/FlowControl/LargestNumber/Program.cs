using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(Math.Max(input1, Math.Max(input2, input3)) + " is the largest number!");
            Console.ReadLine();
        }
    }
}

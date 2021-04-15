using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            double average;
            const int lowerBound = 1;
            double upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }

            average = sum / upperBound;
            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.Write($"The average is {average}\n\n\n");
        }
    }
}
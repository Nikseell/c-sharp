using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is going to convert minutes into days and years\n");
            Console.Write("Enter minutes: ");
            int min = Convert.ToInt32(Console.ReadLine());

            double day = min / 1440;
            double year = min / 525948;

            Console.WriteLine();
            Console.WriteLine(min + " minutes is approximately " + year + " years and " + day + " days.");
        }
    }
}

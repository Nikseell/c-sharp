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


            /*TimeSpan time = TimeSpan.FromMinutes(min);
            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds,
                time.Milliseconds);
            Console.WriteLine(answer);
            */
        }
    }
}

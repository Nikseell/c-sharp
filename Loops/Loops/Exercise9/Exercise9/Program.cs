using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            int input = 0;
            int res = 0;
            int num1 = 0;
            int num2 = 0;
            int tryCount = 0;
            bool acceptNumber = true;
            Random ran = new Random();

            while (acceptNumber)
            {
                Console.Write("Desired sum: ");
                input = int.Parse(Console.ReadLine());

                if (input <= 1)
                {
                    continue;
                }
                else if (input <= 12)
                {
                    acceptNumber = false;
                }
                else
                {
                    continue;
                }
            }

            while (res != input)
            {
                num1 = ran.Next(1, 7);
                num2 = ran.Next(1, 7);

                res = num1 + num2;
                tryCount++;

                Console.WriteLine($"{num1} and {num2} = {res}");
            }
            Console.WriteLine($"For you to get {res} it took {tryCount} tries.");
        }
    }
}

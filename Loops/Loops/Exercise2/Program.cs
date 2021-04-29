using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());
            int result = n;
            for (i = 0; i < n; i++)
            {
                result = result * n;
                Console.WriteLine(result);
            }

            Console.ReadKey();

        }
    }
}

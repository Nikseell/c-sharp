using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {
            bool acceptInput = true;
            int min = 0;
            int max = 0;

            while (acceptInput)
            {
                Console.Write("Min? ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Max? ");
                max = int.Parse(Console.ReadLine());

                if(min > max)
                {
                    Console.WriteLine("Min value can`t be bigger then max!");
                    continue;
                } else
                {
                    acceptInput = false;
                }
            }
            
            for(int i = min; i <= max; i++)
            {
                for(int j = i; j <= max; j++)
                {
                    Console.Write(j);
                }

                for (int j = min; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}

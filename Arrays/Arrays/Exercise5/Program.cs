using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };

            var indexOfElement36 = -1;
            var indexOfElement29 = -1;
            var secondIndexOfElement36 = -1;
            var secondIndexOfElement29 = -1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == 36)
                {
                    secondIndexOfElement36 = i;
                }
                if (myArray[i] == 29)
                {
                    secondIndexOfElement29 = i;
                }
            }

            Console.WriteLine("Solution 1 - using Array.IndexOf()");
            Console.WriteLine("Index position of 36 is: " + indexOfElement36);
            Console.WriteLine("Index position of 29 is: " + indexOfElement29 + "\n");

            Console.WriteLine("Solution 2 - using For loop");
            Console.WriteLine("Index position of 36 is: " + secondIndexOfElement36);
            Console.WriteLine("Index position of 29 is: " + secondIndexOfElement29);
            Console.ReadKey();
        }
    }
}

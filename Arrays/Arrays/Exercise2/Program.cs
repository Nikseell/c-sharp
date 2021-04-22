using System;

namespace Exercise2
{
    class Program
    {
        
        private static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var sum = 0;

            for (int i = 0; i < myArray.Length; i++) {
                sum += myArray[i];
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
            }
        }
}

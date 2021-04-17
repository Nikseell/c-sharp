using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            int[] array1 = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array[i];
            }

            array[array.Length - 1] = -7;

            Console.WriteLine("Array1");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Array2");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }

        }
    }
}

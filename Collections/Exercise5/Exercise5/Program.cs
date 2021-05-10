using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        static List<int> listOfInts = new List<int>();
        static int res = 0;
        static string message = "";
        static int temp = 0;
        static void Main(string[] args)
        {

            Console.Write("Enter number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            temp = input;

            ToDigets(input);
            Calc();

            while (res > 1)
            {
                message = "";
                ToDigets(res);
                res= 0;
                Calc();

                if(res == 16)
                {
                    break;
                }
            }

            if (res == 1)
            {
                Console.WriteLine("Happy number!");
            }
            else
            {
                Console.WriteLine("Not happy!");
            }

        }

        private static void ToDigets(int num)
        {
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }

            listOfInts.Reverse();
        }

        private static void Calc()
        {
            for (int i = 0; i < listOfInts.Count; i++)
            {
                message += listOfInts[i] + "^2 + ";
                res += (int)Math.Pow(listOfInts[i], 2);
            }

            message = message.Remove(message.Length - 2);
            Console.WriteLine(message + "= " + res);
            listOfInts.Clear();
        }
    }
}

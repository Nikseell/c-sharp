﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };
            Console.WriteLine(string.Join(",", firstList));

            var secondList = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "White",
                "Pink"
            };

            secondList.AddRange(firstList);
            Console.WriteLine(string.Join(",", secondList));

            Console.ReadKey();
        }
    }
}

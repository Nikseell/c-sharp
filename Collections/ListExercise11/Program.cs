using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "White",
                "Red",
                "Blue",
                "Purple",
                "Orange",
                "Yellow",
                "Brown",
                "Gray",
                "Green",
                "Pink"
            };

            list.Insert(4, "Cyan");

            list[list.Count - 1] = "Black";

            list.Sort();

            if (list.Contains("Foobar"))
            {
                Console.WriteLine("Contains!");
            }
            else
            {
                Console.WriteLine("Doesn`t contain!");
            }

            foreach (var color in list)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}

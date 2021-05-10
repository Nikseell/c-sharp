using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";
        private static string allGrades = "";
        private static List<int> grades = new List<int>();
        private static int count = 0;

        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);

            foreach (var s in readText)
            {
                allGrades += s;
            }

            grades = allGrades.Split(' ').Select(Int32.Parse).ToList();

            Calc(0, 9);
            Calc(10, 19);
            Calc(20, 29);
            Calc(30, 39);
            Calc(40, 49);
            Calc(50, 59);
            Calc(60, 69);
            Calc(70, 79);
            Calc(80, 89);
            Calc(90, 99);
            Calc(100, 100);
            Console.ReadKey();
        }

        private static void Calc(int from, int to)
        {
            for (int x = 0; x < grades.Count; x++)
            {
                if (grades[x] >= from && grades[x] <= to)
                {
                    count++;
                }
            }

            if(from < 10 && to < 10)
            {
                Console.WriteLine($"0{from}-0{to}: " + new string('*', count));
            }
            else if(from < 10)
            {
                Console.WriteLine($"0{from}-{to}: " + new string('*', count));
            }
            else if(to < 10)
            {
                Console.WriteLine($"{from}-0{to}: " + new string('*', count));
            }
            else if(from == 100 && to == 100)
            {
                Console.WriteLine($"{to}: " + new string('*', count));
            }
            else
            {
                Console.WriteLine($"{from}-{to}: " + new string('*', count));
            }
            count = 0;
        }
    }
}

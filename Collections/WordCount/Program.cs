using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var lineCount = 0;
            var textWords = "";
            string[] lines = File.ReadAllLines(@"..\..\lear.txt");

            foreach(var line in lines)
            {
                Console.WriteLine(line);
                textWords += line;
                lineCount++;
            }

            var charArr = textWords.ToCharArray();
            var arr = textWords.Split(' ', ',', '?', '!').ToArray();

            Console.WriteLine("\nLines: " + lineCount + "\nWord Count: " + arr.Length + "\nChar Count: " + charArr.Length);
            Console.ReadKey();
        }
    }
}

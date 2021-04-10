using System;

namespace UpperCaseCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to count how many uppercase letter there is!\n");
            string sentence = Console.ReadLine();
            Console.WriteLine("");
            int countUpper = 0, i;

            for (i = 0; i < sentence.Length; i++)
            {
                if(char.IsUpper(sentence[i]))
                {
                    countUpper++;
                }
            }
            Console.WriteLine("There are " + countUpper + " uppercases in the sentence.");
        }
    }
}

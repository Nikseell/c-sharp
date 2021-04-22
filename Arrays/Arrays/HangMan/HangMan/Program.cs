using System;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "auss", "upe", "tesla", "klusums" };
            var random = new Random();
            var word = words[random.Next(0, words.Length - 1)];
            var limit = 0;
            var missed = string.Empty;
            var masked = new string('_', word.Length);
            var wordArr = word.ToCharArray();
            var maskArr = masked.ToCharArray();

            while (limit <= 5)
            {
                Console.WriteLine($"Word: {masked}");
                Console.WriteLine($"Misses: {missed}");
                Console.Write("Guess: ");
                var guessKey = Console.ReadKey();
                Console.WriteLine();
                var index = word.ToLower().IndexOf(guessKey.KeyChar);

                if (index > -1)
                {
                    for (int i = index; i < wordArr.Length; i++)
                    {
                        if (wordArr[i] == guessKey.KeyChar)
                        {
                            maskArr[i] = word[i];
                            masked = new string(maskArr);
                        }
                    }
                    maskArr[index] = word[index];
                    masked = new string(maskArr);
                }
                else
                {
                    missed += guessKey.KeyChar.ToString();
                    limit++;
                }

                if (!masked.Contains("_"))
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine("The word was: " + word);
                    break;
                }
            }

            if (limit == 5)
            {
                Console.WriteLine("You lose!");
            }
            Console.ReadKey();

        }
    }
}

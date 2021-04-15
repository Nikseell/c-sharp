using System;

namespace PhoneKeyPad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine();

            int digit = 0;


            for (int i = 0; i < str.Length; i++)
            {
                var letters = str[i].ToString().ToLower();
                if(letters == "a" || letters == "b" || letters == "c")
                {
                    digit = 2;
                }
                else if (letters == "d" || letters == "e" || letters == "f")
                {
                    digit = 3;
                }
                else if (letters == "g" || letters == "h" || letters == "i")
                {
                    digit = 4;
                }
                else if (letters == "j" || letters == "k" || letters == "l")
                {
                    digit = 5;
                }
                else if (letters == "m" || letters == "n" || letters == "o")
                {
                    digit = 6;
                }
                else if (letters == "p" || letters == "q" || letters == "r" || letters == "s")
                {
                    digit = 7;
                }
                else if (letters == "t" || letters == "u" || letters == "v")
                {
                    digit = 8;
                }
                else if (letters == "w" || letters == "x" || letters == "y" || letters == "z")
                {
                    digit = 9;
                }
                else if (letters == " ")
                {

                }
                else
                {
                    Console.Write(" Invalid input ");
                }
                Console.Write(digit);
            }
        }
    }
}

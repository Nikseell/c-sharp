using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    //Write a console program that asks the user for a list of names(one per line) until the user enters a blank line(i.e., just presses Enter when asked for a name). At that point the program should print out the list of names entered, where each name is listed only once(i.e., uniquely) no matter how many times the user entered the name in the program.For example, your program should behave as follows:
    class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;
            var list = new List<string>();

            while (isActive)
            {
                Console.Write("Enter name: ");
                var input = Console.ReadLine();

                if(input != "")
                {
                    list.Add(input);
                }
                else
                {
                    isActive = false;
                    var res = list.Distinct().ToList();

                    Console.Write("Unique name list contains: ");

                    foreach(var name in res)
                    { 
                        Console.Write(name + " ");
                    }
                }
            }
        }
    }
}

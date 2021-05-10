using System;
using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> list = new SortedDictionary<string, string>();

        public PhoneDirectory()
        {

        }

        public void GetNumber(string name)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list.ContainsKey(name))
                {
                    Console.WriteLine($"{name} number is {list.Values}");
                }
            }
        }

        public void PutNumber(string name, string number)
        {
            if (name == null || number == null)
            {
                Console.WriteLine("Name and number cannot be null");
            }
            else if (list.ContainsKey(name))
            {
                Console.WriteLine("Name already exists!");
            }
            else if (list.ContainsKey(number))
            {
                Console.WriteLine("Number already exists!");
            }
            else
            {
                list.Add(name, number);
            }
        }

        public void PrintOut()
        {
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
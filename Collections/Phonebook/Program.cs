using PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phone1 = new PhoneDirectory();
            phone1.PutNumber("Paul", "61323436");
            phone1.PutNumber("Paul", "67219836");
            phone1.PutNumber(null, null);
            phone1.PrintOut();

            Console.ReadKey();
        }
    }
}

using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTest();
        }

        public static void DateTest()
        {
            Date date1 = new Date(24, 9, 1999);
            Date date2 = new Date(23, 8, 2010);

            Console.WriteLine(date1.DisplayDate());
            Console.WriteLine(date2.DisplayDate());
        }
    }
}

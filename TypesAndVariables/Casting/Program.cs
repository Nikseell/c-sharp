using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            String aString = "1";
            int a = Convert.ToInt32(aString);
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            //fixme - should be 15 :|
            int sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }

        static void second()
        {
            String aString = "1";
            int a = Convert.ToInt32(aString);
            int b = 2;
            int c = 3;
            double d = 4.2;
            double e = Math.Round(5.3f, 2);

            //fixme - should be 15.5 :| 
            double sum = a + b + c + d + e;
            Console.WriteLine(sum);
        }
    }
}
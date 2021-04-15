using System;

namespace PrintDayInWord
{
    class Program
    {
        static int numberOfDay = 0;
        static bool menu = true;
        static void Main(string[] args)
        {
            while (menu)
            {
                Console.WriteLine("Select display method: ");
                Console.WriteLine("1. Nested -if statement");
                Console.WriteLine("2. Switch-case-default statement");
                Console.Write("Your selection: ");
                int input = Int32.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (input)
                {
                    case 1:
                        menu = false;
                        AskForDay();
                        DayInWorldUsingIf();
                        break;
                    case 2:
                        menu = false;
                        AskForDay();
                        DayInWorldUsingCase();
                        break;
                    default:
                        menu = true;
                        break;

                }
            }

        }

        private static void AskForDay()
        {
            Console.Write("Enter the number of the day: ");
            numberOfDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        private static void DayInWorldUsingIf()
        {

            if (numberOfDay <= 0 || numberOfDay > 7)
            {
                Console.WriteLine("Not a Valid day!");
                Console.ReadKey();
            }
            else if (numberOfDay == 1)
            {
                Console.WriteLine("Monday");
                Console.ReadKey();
            }
            else if (numberOfDay == 2)
            {
                Console.WriteLine("Tuesday");
                Console.ReadKey();
            }
            else if (numberOfDay == 3)
            {
                Console.WriteLine("Wednesday");
                Console.ReadKey();
            }
            else if (numberOfDay == 4)
            {
                Console.WriteLine("Thursday");
                Console.ReadKey();
            }
            else if (numberOfDay == 5)
            {
                Console.WriteLine("Friday");
                Console.ReadKey();
            }
            else if (numberOfDay == 6)
            {
                Console.WriteLine("Saturday");
                Console.ReadKey();
            }
            else if (numberOfDay == 7)
            {
                Console.WriteLine("Sunday");
                Console.ReadKey();
            }
        }

        private static void DayInWorldUsingCase()
        {
            switch (numberOfDay)
            {
                case 1:
                    Console.WriteLine("Monday");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    Console.ReadKey();
                    break;
                default:
                    menu = false;
                    break;
            }
        }
    }
}

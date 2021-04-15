using System;

namespace HowMuchPay
{
    class Program
    {
        static double minimumWage = 8;
        static double maxHours = 60;
        static double basePay = 0;
        static double hoursWorked = 0;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Employee " + i);
                Console.Write("Enter base pay: ");
                basePay = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter hours worked: ");
                hoursWorked = Convert.ToDouble(Console.ReadLine());
                salaryCalc();
            }
        }

        public static void salaryCalc()
        {
            double totalSalary = 0;
            if ((basePay < minimumWage))
            {
                Console.WriteLine("Base pay is smaller then minimum wage!\n");
            }
            else if ((hoursWorked > maxHours))
            {
                Console.WriteLine("Error!\n");
            }
            else
            {
                if (hoursWorked > 40)
                {
                    totalSalary = basePay * 40 + 1.5 * basePay * (hoursWorked - 40);
                }
                else
                {
                    totalSalary = basePay * hoursWorked;
                }
                Console.WriteLine("Your total salary is " + totalSalary + "\n");
            }
        }
    }
}

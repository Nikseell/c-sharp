using System;

namespace SavingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            double money = Convert.ToDouble(Console.ReadLine());
            var account = new SavingsAccount(money);

            Console.Write("Enter the annual interest rate: ");
            double annualInterest = Convert.ToDouble(Console.ReadLine());
            account.MonthlyInterestRate(annualInterest);

            Console.Write("How long has the account been opened? ");
            int input = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < input; i++)
            {
                Console.Write($"Enter amount deposited for month: {i + 1}: ");
                double depositedAmount = Convert.ToDouble(Console.ReadLine());
                account.Deposit(depositedAmount);

                Console.Write($"Enter amount withdrawn for {i + 1}: ");
                double withdrawnAmount = Convert.ToDouble(Console.ReadLine());
                account.Withdrawn(withdrawnAmount);
                account.MonthlyInteresetEarned();
            }

            Console.WriteLine($"Total deposited: ${account.TotalDeposit().ToString("0.00")}");
            Console.WriteLine($"Total withdrawn: ${account.TotalWithdrawn().ToString("0.00")}");
            Console.WriteLine($"Interest earned: ${account.Interest().ToString("0.00")}");
            Console.WriteLine($"Ending balance: ${account.Balance().ToString("0.00")}");

        }
    }
}

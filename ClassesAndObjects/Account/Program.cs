using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var mattsAccount = new Account("Matt`s Account", 1000);
            var myAccount = new Account("My account", 0);
            var withdraw = mattsAccount.withdrawal(100);
            myAccount.deposit(withdraw);

            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            var aAccount = new Account("A account", 100.00);
            aAccount.deposit(20.00);
            var bAccount = new Account("B account",0);
            var cAccount = new Account("C Account", 0);
            Console.WriteLine("\nInitial state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);
            aAccount.Name = "GGGG";
            Transfer(aAccount,bAccount, 50.0);
            Transfer(bAccount,cAccount, 25.0);

            Console.WriteLine();
            Console.WriteLine("Final state");
            Console.WriteLine(aAccount);
            Console.WriteLine(bAccount);
            Console.WriteLine(cAccount);

            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.deposit(from.withdrawal(howMuch));
        }
    }
}

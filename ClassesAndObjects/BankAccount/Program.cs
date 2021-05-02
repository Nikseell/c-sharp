using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Benson", -17.50);

            account1.ShowUserNameAndBalance();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Account
    {
        private string _name;
        private double _bilance;

        public Account(string name, double bilance)
        {
            _name = name;
            _bilance = bilance;
        }

        public void ShowUserNameAndBalance()
        {
            if(_bilance < 0)
            {
                Console.WriteLine($"{_name}, ${String.Format("{0:0.00}", _bilance * -1)}");
            }
            else
            {
                Console.WriteLine($"{_name}, ${String.Format("{0:0.00}", _bilance)}");
            }
        }
    }
}

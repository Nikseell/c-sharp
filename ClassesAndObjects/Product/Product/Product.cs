using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        private double _price;
        private int _amount;
        private string _name;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _price = priceAtStart;
            _amount = amountAtStart;
        }

        public void ChangeQuantity(int amount)
        {
            _amount = amount;
        }

        public void ChangePrice(double price)
        {
            _price = price;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_name}, price {_price}, amount {_amount}");
        }

    }
}

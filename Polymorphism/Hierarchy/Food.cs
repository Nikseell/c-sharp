using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        public int quantity { set; get; }

        public Food(int quantity)
        {
            this.quantity = quantity;
        }
    }

    public class Vegetable : Food
    {
        public Vegetable(int quantity) : base(quantity)
        {

        }
    }

    public class Meat : Food
    {
        public Meat(int quantity) : base(quantity)
        {

        }
    }
}

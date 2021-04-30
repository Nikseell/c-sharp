using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product item1 = new Product("Logitech mouse", 70.00, 14);
            Product item2 = new Product("Iphone 5s", 999.99, 3);
            Product item3 = new Product("Epson EB-U05", 440.46, 1);

            item1.PrintProduct();
            item2.PrintProduct();
            item3.PrintProduct();

            item1.ChangeQuantity(10);
            item1.ChangePrice(85.00);

            item2.ChangeQuantity(6);
            item2.ChangePrice(1200.99);

            Console.WriteLine("\nChanged quantity and price for item1 and item2:\n");
            item1.PrintProduct();
            item2.PrintProduct();
            item3.PrintProduct();

            Console.ReadKey();
        }
    }
}

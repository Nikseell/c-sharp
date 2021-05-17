using System;
using System.Collections.Generic;
using System.Linq;

namespace Hierarchy
{
    class Program
    {

        static void Main(string[] args)
        {
            bool isActive = true;
            var list = new List<string>();

            while (isActive)
            {
                Console.WriteLine("Enter animal type, name, weigth, living region, (breed if its a cat). \nEverything has to be separated by space. \nTo exit type 'End'\n");
                List<string> details = Console.ReadLine().ToString().Split(' ').ToList();

                if (details[0] == "End" || details[0] == "end")
                {
                    foreach (var a in list)
                    {
                        Console.WriteLine(a);
                    }
                    break;
                }
                var animal = Animal(details);
                animal.MakeSound();

                Console.WriteLine("Enter type of food and amount. \nEverything has to be separated by space\n");
                List<string> food = Console.ReadLine().ToString().Split(' ').ToList();
                var eat = Food(food);
                animal.Eat(eat);
                list.Add(Convert.ToString(animal));
            }
        }

        public static Animal Animal(List<string> details)
        {
            var type = details[0];
            var name = details[1];
            double weight = Convert.ToDouble(details[2]);
            var livingRegion = details[3];

            if (type == "Mouse")
            {
                return new Mouse(name, type, weight, livingRegion);
            }
            else if (type == "Zebra")
            {
                return new Zebra(name, type, weight, livingRegion);
            }
            else if (type == "Cat")
            {
                var breed = details[4];
                return new Cat(type, name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                return new Tiger(name, type, weight, livingRegion);
            }
            else
            {
                throw new Exception("Invalid Animal");
            }
        }

        public static Food Food(List<string> food)
        {
            if (food[0] == "Meat")
            {
                return new Meat(Convert.ToInt32(food[1]));
            }
            else if (food[0] == "Vegetable")
            {
                return new Vegetable(Convert.ToInt32(food[1]));
            }
            else
            {
                throw new Exception("Invalid Food");
            }
        }
    }
}
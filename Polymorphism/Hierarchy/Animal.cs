using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public Animal(string animalName, string animalType, double animalWeigth)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeigth;
        }

        public virtual void MakeSound()
        {

        }

        public virtual void Eat(Food food)
        {

        }

        public string AnimalName
        {
            get { return _animalName; }
            set { _animalName = value; }
        }

        public string AnimalType
        {
            get { return _animalType; }
            set { _animalType = value; }
        }
        public double AnimalWeight
        {
            get { return _animalWeight; }
            set { _animalWeight = value; }
        }
        public int FoodEaten
        {
            get { return _foodEaten; }
            set { _foodEaten = value; }
        }
    }

    public abstract class Mammal : Animal
    {
        private string _livingRegion;

        public Mammal(string animalName, string animalType, double animalWeigth, string livingRegion) : base(animalName, animalType, animalWeigth)
        {
            _livingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{AnimalType} [{AnimalName}, {AnimalWeight}, {_livingRegion}, {FoodEaten}]";
        }
    }

    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeigth, string livingRegion) : base(animalName, animalType, animalWeigth, livingRegion)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Pii - pii");
        }

        public override void Eat(Food food)
        {
            if (food.ToString().Contains("Vegetable"))
            {
                FoodEaten += food.quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType}s are not eating that type of food!\n");
            }
        }
    }

    public abstract class Falime : Mammal
    {
        public Falime(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {

        }
    }

    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion) : base(animalName, animalType, animalWeight, livingRegion)
        {

        }
        public override void MakeSound()
        {
            Console.WriteLine("Zee - zee");
        }

        public override void Eat(Food food)
        {
            if (food.ToString().Contains("Vegetable"))
            {
                FoodEaten += food.quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType}s are not eating that type of food!\n");
            }
        }
    }

    public class Cat : Falime
    {
        private string _livingRegion;
        private string _breed;
        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed) : base(animalName, animalType, animalWeight, livingRegion)
        {
            _livingRegion = livingRegion;
            _breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow - meow");
        }

        public override void Eat(Food food)
        {
            FoodEaten += food.quantity;
        }

        public override string ToString()
        {
            return $"{AnimalType}, [{AnimalName}, {_breed}, {AnimalWeight}, {_livingRegion}, {FoodEaten}]";
        }
    }

    public class Tiger : Falime
    {
        private string _livingRegion;
        public Tiger(string animalName, string animalType, double animalWeigth, string livingRegion) : base(animalName, animalType, animalWeigth, livingRegion)
        {
            _livingRegion = livingRegion;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roaar!");
        }

        public override void Eat(Food food)
        {
            if (food.ToString().Contains("Meat"))
            {
                FoodEaten += food.quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType}s are not eating that type of food!\n");
            }
        }
    }
}

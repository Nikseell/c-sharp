using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    { 
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var carsList = new List<string>();
            carsList.AddRange(array);

            foreach (var car in carsList)
            {
                Console.WriteLine(car);
            }

            var carsHash = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            foreach (var car in carsHash)
            {
                Console.WriteLine(car);
            }

            var carsDict = new Dictionary<string, string>();
            carsDict.Add("Audi", "Germany");
            carsDict.Add("BMW", "Germany");
            carsDict.Add("Honda", "Japan");
            carsDict.Add("Mercedes", "Germany");
            carsDict.Add("VolksWagen", "Germany");
            carsDict.Add("Tesla", "USA");

            foreach (var car in carsDict)
            {
                Console.WriteLine($"{car.Key} -> {car.Value}");
            }
            Console.ReadKey();
        }
    }
}

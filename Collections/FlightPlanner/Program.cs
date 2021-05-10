using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        private static List<string> flightList = new List<string>();
        private static List<Tuple<string, string>> list = new List<Tuple<string, string>>();
        private static List<string> cities = new List<string>();
        private static void Main(string[] args)
        {
            var readText = File.ReadAllLines(Path);

            foreach (var s in readText)
            {
                flightList.Add(s);
            }

            for (int i = 0; i < flightList.Count; i++)
            {
                var temp = flightList[i].Replace("-", "").Split('>');
                list.Add(new Tuple<string, string>(temp[0].Trim(), temp[1].Trim()));
            }

            for (int i = 1; i < list.Count; i++)
            {
                cities.Add(list[i].Item1);
                cities.Add(list[i].Item2);
            }

            var noDupes = cities.Distinct().ToList();

            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine("\nWhat would you like to do: \nTo display list of the cities press 1 \nTo exit program press #");
                Console.Write("> ");
                var input = Console.ReadKey();
                Console.WriteLine();

                if (input.KeyChar == '1')
                {
                    Console.WriteLine("\nList of cities:");
                    foreach (var s in noDupes)
                    {
                        Console.WriteLine(s);
                    }
                    isActive = false;
                    Travel();
                }
                else if (input.KeyChar == '#')
                {
                    break;
                }
            }

            Console.ReadKey();
        }

        private static void Travel()
        {
            Console.Write("\nTo select a city from which you would like to start press 1 > ");
            var input = Console.ReadKey();
            Console.WriteLine();


            if (input.KeyChar == '1')
            {
                var city = "";
                var res = "";
                bool isActive = true;
                bool isActive2 = true;

                while (isActive2)
                {
                    Console.Write("Enter name of your city: ");
                    city = Console.ReadLine();

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].Item1 == city)
                        {
                            Console.WriteLine(list[i].Item1 + " -> " + list[i].Item2);
                            isActive2 = false;
                        }
                    }
                }
                var firstCity = city;
                var copy = "";
                while (isActive)
                {
                    Console.Write("Enter you next city: ");
                    var nextCity = Console.ReadLine();
                    Console.WriteLine();

                    if(nextCity == copy)
                    {
                        Console.WriteLine("You are in this city\n");
                    }

                    if (nextCity == firstCity)
                    {
                        Console.WriteLine($"You have returned to {firstCity}!");
                        isActive = false;
                        break;
                    }

                    for (int i = 0; i < list.Count; i++)
                    {
                        if(nextCity == list[i].Item1)
                        {
                            Console.WriteLine(list[i].Item1 + " -> " + list[i].Item2);
                        }
                    }

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (nextCity == copy)
                        {
                            break;
                        }
                        else if (nextCity == list[i].Item1)
                        {
                            res += nextCity + ", ";
                            break;
                        }
                    }
                    copy = nextCity;
                }

                if (res.Contains(","))
                {
                    res = res.Remove(res.Length - 2).Trim();
                    Console.WriteLine("Your route was: " + firstCity + ", " + res);
                }
            }
        }
    }
}

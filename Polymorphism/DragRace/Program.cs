using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            var cars = new List<ICar> { new Audi(), new Bmw(), new Lexus(), new Tesla(), new Bentley(), new MiniCooper() };

            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < cars.Count; x++)
                {
                    if (i == 0)
                    {
                        cars[x].StartEngine();
                    }

                    if (i == 2)
                    {
                        if (cars[x] is INitrous)
                        {
                            ((INitrous)cars[x]).UseNitrousOxideEngine();
                        }
                    }
                    else
                    {
                        cars[x].SpeedUp();
                    }
                }
            }

            List<ICar> sorted = cars.OrderBy(x => Convert.ToInt32(x.ShowCurrentSpeed())).ToList();

            Console.WriteLine($"\nFastest car: \nName: {sorted.Last().ShowCarName()} \nSpeed: {sorted.Last().ShowCurrentSpeed()}");
            Console.WriteLine("\nAll car results:");

            foreach (var car in sorted)
            {
                Console.WriteLine($"\nName: {car.ShowCarName()} \nSpeed: {car.ShowCurrentSpeed()}");
            }
        }
    }
}
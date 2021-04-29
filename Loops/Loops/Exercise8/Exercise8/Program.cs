using System;
using System.Linq;

namespace Exercise8
{
    class AsciiFigure
    {
        static int lines = 5;
        static int firstStarCount = 8;
        static int splitCount = ((firstStarCount * lines) / 2) - firstStarCount;
        static int starCount = firstStarCount;
        static bool isActive = true;

        static void Main(string[] args)
        {
            drawFigure();
            while (isActive)
            {
                Console.Write("\nFigure has size of 5. Do you want to different size? (y/n) ");
                var input = Console.ReadKey();
                
                if(input.KeyChar == 'y')
                {
                    Console.Write("\nSelect figure size: ");
                    lines = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    firstStarCount = 8;
                    starCount = firstStarCount;
                    splitCount = ((firstStarCount * lines) / 2) - firstStarCount;
                    drawFigure();
                } else
                {
                    isActive = false;
                    Console.Write("\nPress any key to exit..");
                    Console.ReadKey();
                }
            }
        }

        static void drawFigure()
        {
            for (int i = 0; i < 1; i++)
            {
                lines--;
                for (int j = 0; j < (firstStarCount * lines) / 2; j++)
                {
                    Console.Write("/");
                }
                for (int j = 0; j < (firstStarCount * lines) / 2; j++)
                {
                    Console.Write(@"\");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < splitCount; j++)
                {
                    Console.Write("/");
                }
                for (int q = 0; q < starCount; q++)
                {
                    Console.Write("*");
                }
                for (int w = 0; w < splitCount; w++)
                {
                    Console.Write(@"\");
                }

                splitCount = splitCount - 4;
                starCount += firstStarCount;
                Console.WriteLine();
            }
        }
    }
}

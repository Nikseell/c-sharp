using System;

namespace Movies
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies movie1 = new Movies("Casino Royale", "Eon Production", "PG13");
            Movies movie2 = new Movies("Glass", "Buena Vista International", "PG13");
            Movies movie3 = new Movies("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");

            var arr = new Movies[3];

            arr[0] = movie1;
            arr[1] = movie2;
            arr[2] = movie3;

            var res = Movies.GetPG(arr);

            foreach(var mov in res)
            {
                if(mov != null)
                {
                    Console.WriteLine(mov.PrintOut());
                }
            }

        }
    }
}

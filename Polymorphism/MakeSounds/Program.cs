using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> list = new List<ISound> { new Firework(), new Radio(), new Parrot()};

            list.ForEach(s => s.PlaySound());
        }
    }
}
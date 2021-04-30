using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapPoints
{
    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static void SwapPoints(ref Point x, ref Point y)
        {
            Point temp = x;
            x = y;
            y = temp;
        }
    }
}

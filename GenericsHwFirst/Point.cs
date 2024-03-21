using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHwFirst
{
    internal class Point<T>
    {
        public T x;
        public T y;

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void PointInfo()
        {
            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.FirstTask
{
    public class Rectangle : Figure
    {
        public double LengthA;
        public double LengthB;

        public Rectangle(double lengthA, double lengthB)
        {
            this.LengthA = lengthA;
            this.LengthB = lengthB;
        }
        public override double GetPerimeter()
        {
            double p = (LengthA+LengthB)* 2;
            return p;
        }

        public override double GetArea()
        {
            double s = LengthA*LengthB;
            return s;
        }
        public override void GetInfo()
        {
            Console.Write("Прямоугольник: ");
        }
    }
}

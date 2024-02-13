using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.FirstTask
{
    public class Circle : Figure
    {
        public double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetPerimeter()
        {
            double p = 2 * double.Pi * Radius;
            return p;
        }

        public override double GetArea()
        {
            double s = double.Pi * Math.Pow(Radius, 2);
            return s;
        }
        public override void GetInfo()
        {
            Console.Write("Круг: ");
        }
    }
}

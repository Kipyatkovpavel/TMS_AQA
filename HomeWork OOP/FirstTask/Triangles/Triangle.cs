using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_OOP.FirstTask;

namespace HomeWork_OOP.FirstTask.Triangles
{
    public class Triangle : Figure
    {
        public double lengthA;
        public double lengthB;
        public double lengthC;

        public Triangle(double lengthA, double lengthB, double lengthC)
        {
            this.lengthA = lengthA;
            this.lengthB = lengthB;
            this.lengthC = lengthC;
        }
        public override double GetArea() //Расчёт площади по формуле Герона
        {
            double P;
            P = (lengthA + lengthB + lengthC) / 2;
            double area = Math.Sqrt(P * (P -lengthA) * (P - lengthB) * (P - lengthC));
            return area;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.FirstTask
{
    public class Triangle : Figure
    {
        public double LengthA;
        public double LengthB;
        public double LengthC;

        public Triangle(double lengthA, double lengthB, double lengthC)
        {
            this.LengthA = lengthA;
            this.LengthB = lengthB;
            this.LengthC = lengthC;
        }

        public override double GetPerimeter()
        {
            double p = LengthA + LengthB + LengthC;
            return p;
        }

        public override double GetArea()// т.к мы не знаем, какой именно это треугольник, используем универсальную формулу Герона из ДЗ По ООП
        {
            double P;
            P = (LengthA + LengthB + LengthC) / 2;
            double area = Math.Sqrt(P * (P - LengthA) * (P - LengthB) * (P - LengthC));
            return area;
        }
        public override void GetInfo()
        {
            Console.Write("Треугольник: ");
        }
    }
}

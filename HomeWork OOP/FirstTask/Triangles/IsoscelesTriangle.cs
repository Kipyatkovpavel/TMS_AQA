//Равнобедренный треугольник
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.FirstTask.Triangles
{
    public class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double lengthA, double lengthB, double lengthC) : base(lengthA, lengthB, lengthC)
        {
        }

        //расчёт площади Равнобедренного треугольника
        public override double GetArea()
        {
            double side;        //сторона
            double footingside; //основание

            if (lengthA == lengthB)
            {
                side = lengthA;
                footingside = lengthC;
            }
            else if (lengthB == lengthC)
            {
                side = lengthB;
                footingside = lengthA;
            }
            else
            {
                side = lengthC;
                footingside = lengthB;
            }

            double area = (footingside / 4) * Math.Sqrt((4 * Math.Pow(side, 2) - (Math.Pow(footingside, 2))));
            return area;
        }

    }
}

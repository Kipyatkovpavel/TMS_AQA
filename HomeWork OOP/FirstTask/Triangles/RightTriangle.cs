//Прямоугольный треугольник
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.FirstTask.Triangles
{
    public class RightTriangle : Triangles
    {
        public RightTriangle(double lengthA, double lengthB, double lengthC) : base(lengthA, lengthB, lengthC)
        {
        }

        public override double GetArea()
        {
            double cathetus1; //катет1
            double cathetus2; //катет2
            if (lengthB > lengthA)
            {
                cathetus1 = lengthA;

                if (lengthC > lengthB)
                {
                    cathetus2 = lengthB;
                }

                else
                {
                    cathetus2 = lengthC;
                }
            }  
            else
            {
                cathetus1 = lengthB;
                if (lengthC > lengthA)
                {
                    cathetus2 = lengthA;
                }
                else
                {
                    cathetus2 = lengthC;
                }
            }
            double area = (cathetus1*cathetus2)/2;
            return area;

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork_OOP.FirstTask;

namespace HomeWork_OOP.FirstTask.Triangles
{
    public class Triangles : Figure
    {
        public double lengthA;
        public double lengthB;
        public double lengthC;

        public Triangles(double lengthA, double lengthB, double lengthC)
        {
            this.lengthA = lengthA;
            this.lengthB = lengthB;
            this.lengthC = lengthC;
        }
        public override double GetArea() //Расчёт площади по формуле Герона
        {
            double P;
            P = (this.lengthA + this.lengthB + this.lengthC) / 2;
            return double.Sqrt(P * (P -lengthA) * (P - lengthB) * (P - lengthC));
         
        }

    }
}

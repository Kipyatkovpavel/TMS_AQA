//Разносторонний треугольник
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.FirstTask.Triangles
{
    public class ScaleneTriangle : Triangle
    {
        public ScaleneTriangle(double lengthA, double lengthB, double lengthC) : base(lengthA, lengthB, lengthC)
        {
        }
    }

    // Используется формула Герона из родительского класса (Triangles)

}
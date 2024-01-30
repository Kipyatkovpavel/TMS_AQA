using HomeWork_OOP.FirstTask.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.FirstTask
{
    public  class FigureCreator
    {
        public Triangles CreateTriangle(double lengthA, double lengthB, double lengthC)
        {
            //Проверка на равносторонний
            if (lengthA == lengthB && lengthB == lengthC)
            {
                Triangles equilateralTriangle = new EquilateralTriangle(lengthA, lengthB, lengthC);
                return equilateralTriangle;
            }
            //Проверка на разносторонний
            if (lengthA != lengthB && lengthB != lengthC)
            {

            }
;



            //Проверка на равнобедренный
            if ((lengthA * lengthA).Equals(lengthB * lengthB + lengthC * lengthC) ||
                (lengthB * lengthB).Equals(lengthA * lengthA + lengthC * lengthC) ||
                (lengthC * lengthC).Equals(lengthA * lengthA + lengthB * lengthB))
            {
                return new RightTriangle(lengthA, lengthB, lengthC);
            }


                
            
            
        }
    }
}

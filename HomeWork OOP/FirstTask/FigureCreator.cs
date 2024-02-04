using HomeWork_OOP.FirstTask.Triangles;


namespace HomeWork_OOP.FirstTask
{
    public static class FigureCreator
    {
        public static Triangle CreateTriangle(double lengthA, double lengthB, double lengthC)
        {
            //Проверка на равносторонний
            if (lengthA == lengthB && lengthB == lengthC)
            {
               return new EquilateralTriangle(lengthA, lengthB, lengthC);
            }
            //Проверка на равнобедренный
            if (lengthA == lengthB || lengthA == lengthC || lengthB == lengthC)
            {
                return new IsoscelesTriangle(lengthA, lengthB, lengthC);
            }
            //Проверка на прямоугольный
            if ((lengthA * lengthA).Equals(lengthB * lengthB + lengthC * lengthC) ||
                (lengthB * lengthB).Equals(lengthA * lengthA + lengthC * lengthC) ||
                (lengthC * lengthC).Equals(lengthA * lengthA + lengthB * lengthB))
            {
                return new RightTriangle(lengthA, lengthB, lengthC);
            }
            //Проверка на разносторонний
            if (lengthA != lengthB && lengthB != lengthC)
            {
                return new ScaleneTriangle(lengthA, lengthB, lengthC);
            }
            //Проверка на 0 
            if (lengthA == 0 || lengthB == 0 || lengthC == 0)
            {
                throw new Exception("Сторона не может быть 0");
            }
            //Проверка теоремы о 2х сторонах > 3ей
            if ((lengthB + lengthC) <=  lengthA|| (lengthA + lengthC) <= lengthB || (lengthA + lengthB) <= lengthC)                
            {
                throw new Exception("Невозможно построить треугольник с указанынми сторонами.Сумма двух сторон должна быть больше длины третьей стороны ");
            }

        return new Triangle(lengthA, lengthB, lengthC); 
            

        }

    }   
}

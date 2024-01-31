using HomeWork_OOP.FirstTask.Triangles;


namespace HomeWork_OOP.FirstTask
{
    public  class FigureCreator
    {
        public Triangles CreateTriangle(double lengthA, double lengthB, double lengthC)
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

        return new Triangles(lengthA, lengthB, lengthC); 
            


                
            
            
        }
    }
}

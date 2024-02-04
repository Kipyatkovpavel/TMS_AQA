//Равносторонний треугольник

namespace HomeWork_OOP.FirstTask.Triangles
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double lengthA, double lengthB, double lengthC) : base(lengthA, lengthB, lengthC)
        {
        }



        public override double GetArea()
        {
            double area = (double.Sqrt(3) * Math.Pow(lengthA, 2)) / 4;
            return area;
        }
    }
}

// Прямоугольник
namespace HomeWork_OOP.FirstTask
{
    public class Rectangle : Figure
    {
        public double lengthA;
        public double lengthB;

        public Rectangle(double lengthA, double lengthB)
        {
            this.lengthA = lengthA;
            this.lengthB = lengthB;
        }

        public override double GetArea()
        {
            double area = lengthA * lengthB;
            return area;
        }
    }
}

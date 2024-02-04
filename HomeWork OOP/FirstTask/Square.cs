//квадрат
namespace HomeWork_OOP.FirstTask
{
    public class Square : Rectangle
    {
        public Square(double lengthA) : base(lengthA, lengthA)
        {
        }

        public override double GetArea()
        {
            double area = lengthA * lengthA;
            return area;
        }
    }
}

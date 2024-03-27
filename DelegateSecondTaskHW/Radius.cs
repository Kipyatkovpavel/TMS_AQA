using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSecondTaskHW
{
    public class Radius
    {
        delegate double CircleInfo(double x);

        public void CalculateCircle(double x)
        {
            //Возвращение делегатов из метода
            CircleInfo operation = SelectOperation(OperationType.Length);
            Console.WriteLine("Длина вашей окружности:");
            Console.WriteLine(operation(x));

            operation = SelectOperation(OperationType.Square);
            Console.WriteLine("Площадь вашего круга:");
            Console.WriteLine(operation(x));

            operation = SelectOperation(OperationType.Amount);
            Console.WriteLine("Объём шара:");
            Console.WriteLine(operation(x));
        }
        private double Length(double x) => 2 * x * Math.PI;

        private double Square(double x) => Math.Pow(x, 2) * Math.PI;

        private double Amount(double x) => Math.Pow(x, 3) * 4/3 * Math.PI;

        private CircleInfo SelectOperation(OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Length: return Length;
                case OperationType.Square: return Square;
                default: return Amount;
            }
        }
    }
}

using DelegateSecondTaskHW;

namespace DelegateSecondTaskHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");

            if (double.TryParse(Console.ReadLine().Trim(), out double x))
            {
                new Radius().CalculateCircle(x);
            }
            else Console.WriteLine("Неуспешный ввод радиуса.");
        }
    }
}
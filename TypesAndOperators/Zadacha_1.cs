// See https://aka.ms/new-console-template for more information

namespace TMS_AQA
{
    static class Zadacha_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1");


            double a;
            double b;
            char oper;
            double result;



            Console.WriteLine("Введите число 1: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вид математической операции (+,-,*,/): ");
            oper = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Введите число 2: ");
            b = Convert.ToDouble(Console.ReadLine());


            switch (oper)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine($"Ответ " + (a) + " + " + (b) + " = " + (result));
                    break;
                case '-':
                    result = a - b;
                    Console.WriteLine($"Ответ " + (a) + " - " + (b) + " = " + (result));
                    break;
                case '*':
                    result = a * b;
                    Console.WriteLine($"Ответ " + (a) + " * " + (b) + " = " + (result));
                    break;
                case '/':
                    result = a / b;
                    if (b == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                        break;
                    }
                    else
                        Console.WriteLine($"Ответ" + (a) + " / " + (b) + " = " + (result));
                    break;

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Lambda
    {

        delegate void Message();

        public void Example0()
        {
            //(список параметров) => выражение

            string Word()
            {
                return "word";
            }
            string WordLambda() => "word";
            Console.WriteLine(Word());
            Console.WriteLine(WordLambda());
        }

        public void Example1()
        {
            Message hello = () => Console.WriteLine("Hello");
            hello();
            hello();

            Message hello1 = () =>
            {
                Console.WriteLine("Hello");
                Console.WriteLine("MTS");
            };
            hello1();

            var hello2 = () => Console.WriteLine("Hello");
            hello2();

        }

        delegate void Operation(int x, int y);
        delegate void PrintHandler(string message);
        public void Example2()
        {
            //Параметры лямбды
            Operation sum = (x, y) => Console.WriteLine($"{x}+{y} = {x + y}");
            sum(1, 2);
            sum(22, 14);

            //var sum1 = ( x, y) => Console.WriteLine($"{x}+{y} = {x + y}"); Ошибка на уровне компиляции
            var sum1 = (int x, int y) => Console.WriteLine($"{x}+{y} = {x + y}");//Ошибка на уровне компиляции
            sum1(1, 2);

            PrintHandler print = message => Console.WriteLine(message);
            print("Hello MTS");

            var print1 = (string message = "default value") => Console.WriteLine(message);
            print1();
            print1("Another value");
        }

        delegate int Operation1(int x, int y);
        public void Example3()
        {
            var sum = (int x, int y) => x + y;
            int sumresult = sum(4, 5);
            Console.WriteLine(sumresult);

            Operation1 multiplay = (x, y) => x * y;
            int multiplayresult = multiplay(4, 5);
            Console.WriteLine(multiplayresult);

            var subtrack = (int x, int y) =>
            {
                if (x > y) return x - y;

                return y - x;
            };
            int subtractresult = subtrack(4, 5);
            Console.WriteLine(subtractresult);

        }
        public void Example4()
        {
            var hello = () => Console.WriteLine("Hello");
            var message = () => Console.WriteLine("MTC");

            message += () => Console.WriteLine("!!!!!");
            hello += message;
            hello += Print;

            hello();

            hello -= Print;
            hello -= message;

            hello?.Invoke();
            void Print() => Console.WriteLine("Welcome to C#");
        }

        delegate bool IsEqual(int x);
        public void Example5()
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sumResult1 = Sum(integers, x => x > 5);
            Console.WriteLine(sumResult1);

            int sumResult2 = Sum(integers, x => x % 2 == 0);
            Console.WriteLine(sumResult2);

            int Sum(int[] numbers, IsEqual func)
            {
                int result = 0;

                foreach (int number in numbers)
                {
                    if (func(number))
                    {
                        result += number;
                    }
                }
                return result;
            }
        }
        public void Example6()
        {
            Operation1 operation = SelectOperation(OperationType.Add);
            Console.WriteLine(operation(10, 4));
            operation = SelectOperation(OperationType.Subtract);
            Console.WriteLine(operation(10, 4));
            operation = SelectOperation(OperationType.Multiply);
            Console.WriteLine(operation(10, 4));
            Operation1 SelectOperation(OperationType operationType)
            {
                switch (operationType)
                {
                    case OperationType.Add: return (x, y) => x + y;
                    case OperationType.Subtract: return (x, y) => x - y;
                    default: return (x, y) => x * y;
                }
            }
        }
    }
}

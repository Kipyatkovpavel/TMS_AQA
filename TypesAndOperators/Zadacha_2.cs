namespace TMS_AQA // Note: actual namespace depends on the project name.
{
    static class Zadacha_2
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Задача 2");
            double c;

            Console.WriteLine("Введите ваше число (от -50 до 50): ");
            c = Convert.ToDouble(Console.ReadLine());

            if (c >= -40 && c <= -10)
            {
                Console.WriteLine($"Ваше число " + (c) + " попадает в промежуток (-40,-10)");
            }
            else if (c >= -9 && c <= 0)
            {
                Console.WriteLine($"Ваше число " + (c) + " попадает в промежуток (-9,0)");
            }
            else if (c <= 10 && c >= 1)
            {
                Console.WriteLine($"Ваше число " + (c) + " попадает в промежуток (1,10)");
            }
            else if (c <= 40 && c >= 11)
            {
                Console.WriteLine($"Ваше число " + (c) + " попадает в промежуток (11,40)");
            }
            else if (c >= 40.00000000001 && c <= 50)
            {
                Console.WriteLine($"Ваше число " + (c) + " не попадало ни один из промежутков");
            }
            else if (c >= -50 && c <= -40.00000000001)
            {
                Console.WriteLine($"Ваше число " + (c) + " не попадало ни один из промежутков");
            }
            else if (c >= -50.00000000001 || c <= 50.00000000001)
            {
                Console.WriteLine($"Ваше число " + (c) + " находится вне диапозона поиска");
            }
        }
    }
}
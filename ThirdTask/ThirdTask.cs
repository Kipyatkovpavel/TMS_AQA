/*
Задание 3
Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение.
Для генерации случайного числа используйте метод Random() . Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли.

*/
namespace ThirdTaskArrays
{
    public class ThirdTask
    {
        public static void Main(string[] args)
        {
            Console.Write("Укажите размер массива: ");
            int sizeofarrays = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[sizeofarrays];

            for (int i = 0; i < sizeofarrays; i++)
            {
                array[i] = new Random().Next(99);

                Console.Write($"{array[i]} ");
            }
                Console.WriteLine();
                Console.WriteLine($"Максимальное значение в массиве: {array.Max()} ");
                Console.WriteLine($"Минимальное значение в массиве: {array.Min()} ");
                Console.WriteLine($"Средние значение в массиве: {array.Average()} ");
        }
    }
}
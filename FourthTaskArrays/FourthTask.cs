/*Задание 4
Создайте 2 массива из 5 чисел.
Выведите массивы на консоль в двух отдельных строках.
Посчитайте среднее арифметическое элементов каждого массива и сообщите, для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).

*/
using System.ComponentModel.Design;

namespace FourthTaskArrays
{
    public class FourthTask
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Представлены 2 массива чисел: ");
            int[] array1 = new int[5];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Random().Next(10);
                Console.Write($"{array1[i]} ");

            }
            Console.WriteLine();
            int[] array2 = new int[5];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = new Random().Next(10);
                Console.Write($"{array2[i]} ");

            }
            double average1 = array1.Average();
            double average2 = array2.Average();

            Console.WriteLine();
            if (average1 > average2)
            {
                Console.WriteLine($"Среднее арифметическое первого массива {average1} больше среднего аримфметического второго массива {average2}.");
            }
            else if (average1 < average2)
            {
                Console.WriteLine($"Среднее арифметическое второго массива {average2} больше среднего аримфметического первого массива {average1}.");
            }
            else
            {
                Console.WriteLine($"Средние арифметические двух массивов равны {average1}.");
            }
        }
    }
}
//"Массивы и циклы". Задача 1
/*Задание 1 Создайте массив целых чисел. Напишете программу, 
  которая выводит сообщение о том, входит ли заданное число 
 в массив или нет. Пусть число для поиска задается с консоли.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskArrays
{
    public class FirstTask
    {
        public static void Main(string[] args)
        {
            Console.Write("Представлен массив чисел: ");
            int[] array = new int[30];

            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
                Console.Write($"{array[i]} ");

            }
            Console.WriteLine();

            Console.Write("Введите ваше число: ");
            int checkNumber = Convert.ToInt32(Console.ReadLine());

            bool CheckInArray = false;
            foreach (int i in array)
            {
                if (checkNumber == i)
                {
                    CheckInArray = true;
                    break;
                }
            }
            if (CheckInArray) 
            {
                Console.WriteLine($"Ваше число {checkNumber} входит в массив ");
            }
            else
            {
                Console.WriteLine($"Ваше число {checkNumber} не входит в массив ");
            }
        }

    }
}

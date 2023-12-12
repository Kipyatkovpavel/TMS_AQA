/*Задание 2 . Создайте массив целых чисел. Удалите все вхождения заданного числа из массива.
Пусть число задается с консоли. Если такого числа нет - выведите сообщения об этом.
В результате должен быть новый массив без указанного числа.

*/
namespace SecondTaskArrays
{
    public class SecondTask
    {
        public static void Main(string[] args)
        {
            Console.Write("Представлен массив чисел: ");
            int[] array = new int[25];

            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                array[i] = new Random().Next(100);
                Console.Write($"{array[i]} ");

            }
            Console.WriteLine();

            Console.Write("Введите число, которое вы хотите удалить: ");
            int NumberToDelete = Convert.ToInt32(Console.ReadLine());

            int count = 0; //прорерка на количество совпадений
            foreach (int item in array)
            {
                if (item == NumberToDelete) count++;
            }

            int[] Newarray = new int[array.Length - count];
            int Index = 0;
            foreach (var item in array)
            {
                if (item != NumberToDelete)
                {
                    Newarray[Index] = item;
                    Index++;
                }
            }

            if (count > 0)
            {
                Console.Write("Новый массив: ");
                foreach (var num in Newarray)
                {
                    Console.Write(num + " ");
                }
            }
            else
            {
                Console.WriteLine($"Число {NumberToDelete} не найдено в массиве.");
            }
        }    
    }
}

//Задание не закончено, почему то при удалении числа, он удаляет его из массива, но при этом ставить дополнительный 0 в конце массива.
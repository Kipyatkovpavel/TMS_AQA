using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateThirdTaskHW
{
    public delegate int[] SortDelegate(int[] array);
    public class Sort
    {
        public void SortDelegate(int[] array)
        {
            SortDelegate sortdelegate = SelectOperation(SortType.BubbleSort);
            Console.Write("Отсортированный массив пузырьковым: ");
            foreach (var item in sortdelegate(array))
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            SortDelegate sortdelegate1 = SelectOperation(SortType.SortAscending);
            Console.Write("Отсортированный массив обычной сортировкой: ");
            foreach (var item in sortdelegate(array))
            {
                Console.Write($"{item} ");
            }

        }
        public static int[] BubbleSort(int[] array) 
        {
            int[] result = new int[array.Length];

            for( int i =0;i < array.Length; i++ )
            {
                for (int j = 0;j < array.Length -1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j +1] = temp;
                    }
                }
            }

            return array;
        }

        public int[] SortAscending(int[] array)
        {
            Array.Sort(array);
            return array;
        }


        public SortDelegate SelectOperation(SortType sortType)
        {
            SortDelegate sortdelegate;
            switch (sortType)
            {
                case SortType.BubbleSort: return  sortdelegate = BubbleSort;
                default: return SortAscending;
            }
        }
    }
}

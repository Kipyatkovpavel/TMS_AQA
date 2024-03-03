﻿using Collections.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IList
{
    public class ArrayListExample
    {
        public void Run()
        {
            //Создаем ArrayList для хранения строк
            ArrayList stringList = new ArrayList();
            // Console.WriteLine(stringList.Capacity);

            // Добавляем элементы в ArrayList
            stringList.Add("Первый");
            stringList.Add("Второй");
            stringList.Add("Третий");



            // Создаем ArrayList для хранения строк в С# 12
            ArrayList stringList1 =
            [
            "Первый",
                2,
                false,
                new StringBuilder("Object")
            ];

            Console.WriteLine("Элементы ArrayList: ");
            foreach (var str in stringList1)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine(stringList.Capacity); //коллекции увеличиваются в два раза (а не на то кол-во элементов, которые мы добавляем) и только когда доходит до границы capacity

            // Добавляем элементы в ArrayList с разными типами данных
            stringList.Add(4); // Допустимо, но не рекомендуется
            stringList.Add(true); // Допустимо, но не рекомендуется
            stringList.Add(new StringBuilder("Object")); // Допустимо, но не рекомендуется
            Console.WriteLine(stringList.Capacity);

            // Выводим элементы после добавления разных типов данных
            Console.WriteLine("\nЭлементы в ArrayList после добавления числа и булевого значения:");
            PrintHelper.PrintCollection(stringList);
        }

    }
}

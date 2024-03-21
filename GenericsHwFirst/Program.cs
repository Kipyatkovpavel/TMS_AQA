// See https://aka.ms/new-console-template for more information

using System.Drawing;
using GenericsHwFirst;
Console.WriteLine("Задание 1");
Console.WriteLine("Вывод координат точек: ");

Point<int> intPoint = new Point<int>(5, 7);
intPoint.PointInfo();

Point<double> doublePoint = new Point<double>(10.2, 15.2);
doublePoint.PointInfo();

Point<string> strPoint = new Point<string>("проверках", "проверкаy");
strPoint.PointInfo();
Console.WriteLine("Задание 2");
Console.WriteLine("Интовый массив: ");
Array<int> intArray = new Array<int>();
intArray.Add(5);
intArray.Add(7);
intArray.Add(10);

Console.WriteLine("Данные после добавления: ");
intArray.PrintArray();

int checkelement = intArray.GetIndex(1);
Console.WriteLine($"Вывести элемент по индексу(1): {checkelement}");

Console.WriteLine("Проверка после удаления по 0 индексу: ");
intArray.Remove(0); //удаление 0 по индексу
intArray.PrintArray();

Console.WriteLine($"Длина массива: {intArray.GetLenght()}");

Console.WriteLine("Стринговый массив: ");
Array<string> strArray = new Array<string>();
strArray.Add("пять");
strArray.Add("семь");
strArray.Add("десять");


Console.WriteLine("Данные после добавления: ");
strArray.PrintArray();

string checkelement1 = strArray.GetIndex(1);
Console.WriteLine($"Вывести элемент по индексу(1): {checkelement1}");

Console.WriteLine("Проверка после удаления по 0 индексу: ");
strArray.Remove(0); //удаление 0 по индексу
strArray.PrintArray();

Console.WriteLine($"Длина массива: {strArray.GetLenght()}");
// See https://aka.ms/new-console-template for more information
using DelegateThirdTaskHW;

var random = new Random();
var array = new int[15];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1000);

}
Console.WriteLine("Исходный массив: {0}", string.Join(", ", array));
new Sort().SortDelegate(array);

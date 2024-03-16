// See https://aka.ms/new-console-template for more information

using System.Linq;

public class Program
{
    public static void Main()
    {
        string input = "1, 2, 3, 4, 4, 5";
        string[] numbers = input.Split(',');//разделение строки
        List<string> uniqueNumbers = numbers.Distinct().ToList();//distinct-удаление повтр.элементов
        string newnumbers = string.Join(",", uniqueNumbers);
        Console.WriteLine(newnumbers);
    }
}
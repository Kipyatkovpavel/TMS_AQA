namespace StringApp;

public static class FourthTask
{
    static void Main(string[] args)
    {
        string f_str = "Плохой день.";
        f_str = f_str.Replace(f_str.Substring(0, 6), "");
        string newstr = f_str.Insert(0,"Хороший").Replace(".", "!!!!!!!");
        newstr = newstr.Remove(newstr.LastIndexOf('!')).Insert(newstr.Length - 1, "?");

        Console.WriteLine($"Исправленная строка: {newstr}");



    }

}
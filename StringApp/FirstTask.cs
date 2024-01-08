/*using System.Text.RegularExpressions;

namespace StringApp
{
    public static class FirstTask
        {
        static void Main(string[] args)
        {
            string originaltext = "In agile software development, test cases are more like outlines than a list of step-by-step instructions for a single test.\n" + "Kent Beck writes the SUnit testing framework for Smalltalk (source) 1998: article on Extreme Programming mentions that \"we usually write the test first\" (source) 1998 to 2002";

            Console.WriteLine($"Исходный текст: {originaltext}");
            string replasetext1 = originaltext.Replace("test", "testing");
            string replasetext2 = Regex.Replace(replasetext1, "[0-9]", "");
            Console.WriteLine();
            Console.WriteLine($"Измененный текст:{replasetext2}");

        }
    }
}
*/
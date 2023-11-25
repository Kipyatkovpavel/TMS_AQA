namespace TMS_AQA // Note: actual namespace depends on the project name.
{
    static class Zadacha_4
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Задача 4");

            //Решение1
            int numb;

            Console.WriteLine("Введите ваше число: ");
            numb = Convert.ToInt32(Console.ReadLine());
            if ((numb % 2) == 0) //0 это значит, что делится без остатка
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }


        }
    }
}
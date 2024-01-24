global using Classes.Models;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        //Задание 1.
        {
            Phone[] phone = new Phone[]
            {
                new Phone(),
                new Phone(79602002020, "Iphone"),
                new Phone(79165555555, "Galaxy", 350.3f)
            };
            foreach (var n in phone)
            {
                Console.WriteLine($"Number: {n.number}, Model: {n.model}, Weight: {n.weight}");
            }

            foreach (var n in phone)
            {
                Console.WriteLine(n.getNumber());//метод getNumber 
            }


            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            Phone phone3 = new Phone();
            phone1.receiveCall("Бизнес Партнёр");//метод receiveCall
            phone2.receiveCall("Налоговая");
            phone3.receiveCall("Игорь ФСБ");
            Console.WriteLine();

            //использую конструкцию из прошой части задания
            /* 
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
             */
            phone1.sendMessage(79165555555, 79165555556);//метод sendMessage
            Console.WriteLine();
            phone2.sendMessage(79165555557, 79165555558, 79122222243, 79122222244, 79122222245);

            //Задание 2.
            CreditCard creditcard1 = new CreditCard(55454541151, 20000);
            CreditCard creditcard2 = new CreditCard(22222245411, 400000);
            CreditCard creditcard3 = new CreditCard(33333333333, 8000000);

            creditcard1.FirstBalance();
            creditcard2.FirstBalance();
            creditcard3.FirstBalance();

            creditcard1.NewSumMoney(5555);
            creditcard2.NewSumMoney(100000);
            creditcard3.NewMinusMoney(9000000);//негативный сценарий
            creditcard3.NewMinusMoney(7000000);//положительный сценарий

            creditcard1.NowBalance();
            creditcard2.NowBalance();
            creditcard3.NowBalance();
        }
    }

}
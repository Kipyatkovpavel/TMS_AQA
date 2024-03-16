// See https://aka.ms/new-console-template for more information


using CollectionsHWsecond;
using System.ComponentModel.Design;
using static System.Formats.Asn1.AsnWriter;

Shop shop = new Shop();

Random random = new Random();
for (int i = 0; i < 3; i++)
{
    int id = random.Next(1, 10);
    string name = "Случайный Продукт" + id;
    double price = random.Next(100, 500);
    double quantity = random.Next(1, 100);   

    shop.AddProduct(name, price, quantity);
}
shop.AddProduct("Молоко", 123, 15);
shop.AddProduct("Морожене", 100.12, 80);
shop.AddProduct("Сникерс", 55.48, 10);
shop.AddProduct("Яблоки", 55.48, 25.5);
Console.WriteLine("-------------------------------------");
Console.WriteLine("Не добавлял проверки на 0 или некорректный ввод, надеемся, что пользователь будет с прямыми руками :)");
Console.WriteLine("Задание 2");
Console.WriteLine("Выберете интересующую вас функцию программы:");
Console.WriteLine("Если вы хотите добавить товар в наш магазин, нажмите \"1\" ");
Console.WriteLine("Если вы хотите увидеть все товары в нашем магазине, нажмите \"2\" ");
Console.WriteLine("Если вы хотите найти интересующий вас товар, нажмите \"3\" ");
Console.WriteLine("Если вы хотите обновить информацию о каком-либо товаре, нажмите \"4\" ");
Console.WriteLine("Если вы хотите убрать товар из нашего магазина, нажмите \"5\" ");
Console.WriteLine("Если выйти из программы, нажмите \"6\" ");

while (true)
{
    var userchoise = Console.ReadLine();
    switch (userchoise)
    {
        case "1":
             Console.WriteLine("Введите название товара: ");
             string nameproduct = Console.ReadLine();
             Console.WriteLine("Введите стоимость товара(если число не целое, то указываем числа через запятую): ");
             double price = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Введите количество на складе(если число не целое, то указываем числа через запятую): ");
             double quantity = Convert.ToDouble(Console.ReadLine());
            shop.AddProduct(nameproduct, price, quantity);
            break;
        case "2":
            shop.ShowAllProduct();
            break;
        case "3":
            Console.WriteLine("Введите id для поиска:");
            int findid = int.Parse(Console.ReadLine());
            shop.FindProduct(findid);
            break;
        case "4":
            Console.WriteLine("Введите id товара:");
            int updateid = int.Parse(Console.ReadLine());
            if (shop.basketproduct.ContainsKey(updateid))
            {
                Console.WriteLine("Выберете интересующую вас функцию программы: \n\"1\"- если хотите изменить цену товара\n\"2\" - количество на складе");
                var userchoise1 = Console.ReadLine();
                switch (userchoise1)
                {
                    case "1":
                        Console.WriteLine("Введите новую стоимость для товара");
                        double updateprice = double.Parse(Console.ReadLine());
                        shop.UpdateInfoPrice(updateid, updateprice);
                        Console.WriteLine("Вы изменили цену на товар!");
                        shop.FindProduct(updateid);
                        break;

                    case "2":
                        Console.WriteLine("Введите новое количество товара");
                        double updatequantity = double.Parse(Console.ReadLine());
                        shop.UpdateInfoQuantity(updateid, updatequantity);
                        Console.WriteLine("Вы изменили количество товара!");
                        shop.FindProduct(updateid);
                        break;
                }
            }
            else
            {
                Console.WriteLine("В нашем магазине не представлен товар по указанному вами id");
            }
            break;           
        case "5":
            Console.WriteLine("Введите id на удаление");
            int removeid = int.Parse(Console.ReadLine());
            shop.RemoveProduct(removeid);
            Console.WriteLine("Список товаров после удаления:");
            shop.ShowAllProduct();
            break;
        case "6":
            Environment.Exit(0); break;
        default:
            Console.WriteLine("Неправильный ввод.Возможно вы выбрали цифру не из списка.");
            break;
    }
}

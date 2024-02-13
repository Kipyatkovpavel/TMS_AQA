// See https://aka.ms/new-console-template for more information

//=================Задание 1

using HomeWork.FirstTask;
using HomeWork.SecondTask;

Console.WriteLine("Задание 1");

Figure[] figures = new Figure[5];
{
    figures[0] = new Circle(4.25f);
    figures[1] = new Triangle(5, 2, 4);
    figures[2] = new Triangle(3, 3, 3);
    figures[3] = new Rectangle(10.4f, 5);
    figures[4] = new Circle(5);
};
    double sumPerimeter = 0;
    double sumArea = 0;
 
    foreach (var figure in figures)
    {
    figure.GetInfo();
    sumPerimeter += figure.GetPerimeter();
    sumArea += figure.GetArea();
    Console.WriteLine($"Периметр {Math.Round(figure.GetPerimeter(), 3)}, Площадь {Math.Round(figure.GetArea(),3)}");
    //Math.Round - используется для сокращения кол-ва символов после запятой, если поставить 2, то конечная цифра округляется некорректно.
    }
    Console.WriteLine($"Общая сумма периметров: {Math.Round(sumPerimeter, 3)}, Общая сумма площадей {Math.Round(sumArea, 3)}");

//=================Задание 2
Console.WriteLine("Задание 2");

BaseProduct[] productsArray = new BaseProduct[5];
productsArray[0] = new Product("Молоко", 123, new DateOnly(2023, 10, 05), new DateOnly(2024, 02, 13));
productsArray[1] = new Product("Кола", 200, new DateOnly(2023, 04, 15), new DateOnly(2025, 03, 20));
productsArray[2] = new Product("Йогурт", 80, new DateOnly(2023, 12, 16), new DateOnly(2024, 01, 15));
productsArray[3] = new Batch("Сникерс", 20, 55, new DateOnly(2023, 08, 16), new DateOnly(2024, 02, 17));

BaseProduct[] productSet = new BaseProduct[3];
productSet[0] = new Product("Яблоки", 220, new DateOnly(2023, 10, 05), new DateOnly(2024, 02, 14));
productSet[1] = new Product("Груши", 400, new DateOnly(2023, 08, 05), new DateOnly(2024, 01, 25));
productSet[2] = new Product("Виноград", 800, new DateOnly(2024, 01, 05), new DateOnly(2024, 03, 25));

productsArray[4] = new Set("Фруктовая тарелка", productSet);


foreach (var product in productsArray)
{
    product.GetProductInfo();
    product.CheckShelfLife();
}

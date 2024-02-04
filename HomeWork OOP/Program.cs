using HomeWork_OOP.FirstTask;
using HomeWork_OOP.SecondTask;
using HomeWork_OOP.ThirdTask;
using HomeWork_OOP.ThirdTask.TransportPark;
using System;
using System.Xml.Serialization;

Console.WriteLine("Задание 1");


                Figure[] figures = new Figure[6]
            {
                FigureCreator.CreateTriangle(51, 2.7f, 50), //разносторонний треугольник
                FigureCreator.CreateTriangle(7, 7, 7), //равносторонний треугольник
                FigureCreator.CreateTriangle(6, 8, 10), // прямоугольный треугольник
                FigureCreator.CreateTriangle(4, 4, 1), // равнобедренный треугольник
                new Rectangle(4, 5),
                new Square(3)
                //эксепшены не сработали, поэтому не стал добавлять
            };

            foreach (var figure in figures)
            {
                var figureArea = figure.GetArea();
                Console.WriteLine($"Площадь фигуры = {figureArea}"); 
            }


//Задача 2.
Console.WriteLine();
Console.WriteLine("Задание 2:");


Patient patient1 = new Patient("Игорь", new PlanOfTreatment(1));
            patient1.TreatPatient();

            Patient patient2 = new Patient("Егор", new PlanOfTreatment(2));
            patient2.TreatPatient();

            Patient patient3 = new Patient("Света", new PlanOfTreatment(3));
            patient3.TreatPatient();

            Patient patient4 = new Patient("Павел", new PlanOfTreatment(40));
            patient4.TreatPatient();


// Задача 3
Console.WriteLine();
Console.WriteLine("Задание 3:");

//Объект класса Bus
Bus bus = new Bus( "ТРЦ Мега", 545, new DateTime(2024, 02, 04, 19, 53, 25), 15);
bus.Print();

//Массив транспорта
Transport[] transport = new Transport[]
    { bus,
    new Tram("Обводный канал", 14, new DateTime(2024, 02, 04, 20, 15, 00), 40),
    new Trolleybus("м.Лесная", 255,new DateTime(2024, 02, 04, 22, 41, 40), 28)
    };
Console.WriteLine();
//Вывод информации о видах транспорта:
TransportService service = new TransportService();

Console.WriteLine("В автопарке представлен следующие виды транспорта: ");
foreach (var  type in transport )
{
    service.printTransportType(type);
}

Console.WriteLine();
Console.WriteLine("Сортировка по количеству мест:");
//Сортировка по количеству мест.
Transport quantity;
for (int i = 0; i < transport.Length - 1; i++)
{
    for (int j = i + 1; j < transport.Length - i - 1; j++)
    {
        if (transport[i].quantityplace > transport[j].quantityplace)
        {
            quantity = transport[i];
            transport[i] = transport[j];
            transport[j] = quantity;
        }

        foreach (Transport a in transport)
        {
            a.Print();
        }

        Console.WriteLine("Укажите пункт назначения (если знаете конечный адрес-укажите его ): ");
        string? endpointpeople = Console.ReadLine();
        Console.WriteLine("Укажите время отправления (в формате дд.мм.гг если хотите оследить отправления по времени,\n если вас интересует конкретный транспорт - Обязательно дополнительно указать чч:мм: сс) :");
        string datetimepeople = Console.ReadLine();
        DateTime converteddatetime = Convert.ToDateTime(datetimepeople);

        try
        {
            int foundTransport = 1;

            foreach (Transport transport1 in transport)
            {
                if (transport1.dateTime == converteddatetime && transport1.endpoint == endpointpeople)
                {
                    transport1.Print();
                    foundTransport++;
                }
                if (foundTransport == 1)
                {
                    Console.WriteLine("Транспорт на точное место, время и дату не найден.");
                    break;
                }
            }
        }
        finally

        {
            Console.WriteLine("Вы можете посмотреть какой транспорт отправляется позже: ");
            int foundTransport2 = 0;
            foreach (Transport transport2 in transport)
            {
                if (transport2.dateTime >= converteddatetime)
                {
                    transport2.Print();
                    foundTransport2++;
                }
            }
            if (foundTransport2 == 0)
            {
                Console.WriteLine("Не найден транспорт на заданную дату и время");
            }
        }
    }

}


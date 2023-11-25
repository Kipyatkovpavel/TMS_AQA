namespace TMS_AQA // Note: actual namespace depends on the project name.
{
    static class Zadacha_3
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Задача 3");

            string weather;


            Console.WriteLine("Введите интересующий вас тип погоды на русском: ");
            weather = Convert.ToString(Console.ReadLine());


            switch (weather.ToLower())
            {
                case "солнечно":
                case "солнце":
                    Console.WriteLine("sunny");
                    break;
                case "облачно":
                case "облака":
                    Console.WriteLine($"cloudy");
                    break;
                case "дождливо":
                case "дождь":
                    Console.WriteLine($"rainy");
                    break;
                case "ветренно":
                case "ветер":
                    Console.WriteLine($"windy");
                    break;
                case "туманно":
                case "туман":
                    Console.WriteLine($"cloudy");
                    break;
                case "снег":
                    Console.WriteLine($"snow");
                    break;
                case "молния":
                    Console.WriteLine($"lightning");
                    break;
                case "жарко":
                    Console.WriteLine($"hot");
                    break;
                case "ясно":
                    Console.WriteLine($"clear");
                    break;
                case "метель":
                    Console.WriteLine($"blizzard");
                    break;
                default:
                    Console.WriteLine($"Переводчик ещё не знает этого слова");
                    break;
            }

        }
    }
}
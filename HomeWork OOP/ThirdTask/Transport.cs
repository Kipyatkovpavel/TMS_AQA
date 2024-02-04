using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork_OOP.ThirdTask
{
    public abstract class Transport
    {
        public string endpoint { get; set; }
        public int number { get; set; }
        public DateTime dateTime { get; set; }
        public int quantityplace { get; set; }
        
        public abstract string GetTransportType();
        public void Print() // Метод, который не переопределить
        {
            Console.WriteLine($"Пункт назначения: {endpoint}, Номер: {number}, Время отправления: {dateTime}, Число мест: {quantityplace}");
        }
    }
}

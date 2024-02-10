using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Example
{
    public class Tablet1 : IDisplayable, IChargeable
    {
        public int SerialNumber;
        public void DisplayInformation(string information)
        {
            // Реализация отображения на экране планшета
            Console.WriteLine($"Tablet Display: {information}");
        }

        public void DrawBorders()
        {
            Console.WriteLine("Tablet: Рисуем границы");
        }

        public void Charge()
        {
            Console.WriteLine("Tablet: Заряжается....");
        }
    }
}

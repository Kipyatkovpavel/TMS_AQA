using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Example
{
    public class Smartphone : IDisplayable
    {
        public int UUID;
        public void DisplayInformation(string information)
        {
            // Реализация отображения на экране смартфона
            Console.WriteLine($"Smartphone Display: {information}");
        }
    }
}

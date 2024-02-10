using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Example
{
    public interface IDisplayable
    {
        void DisplayInformation(string information);

        public void DrawBorders()
        {
            Console.WriteLine($"Рисуем границы");
        }

    }
}

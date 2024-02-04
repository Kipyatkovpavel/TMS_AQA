using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.SecondTask.Doctors
{
    public class Dentist : Doctor
    {
        public override void Healing()
        {
            Console.WriteLine("Дантист лечит зубы");
        }

    }
}

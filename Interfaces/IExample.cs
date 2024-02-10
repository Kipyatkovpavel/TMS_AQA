using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IExample
    {
        // константа
        const int minSpeed = 0;     // минимальная скорость
                                    // статическая переменная     //переменная, которая сущ-ет в рамках программы в единственном экземпляре.Поменять можно, но новое значение будет для всех
        static int maxSpeed = 60;   // максимальная скорость
                                    // метод                    //без тела 
        void Move();                // движение
                                    // свойство
        string Name { get; set; }   // название
    }
}

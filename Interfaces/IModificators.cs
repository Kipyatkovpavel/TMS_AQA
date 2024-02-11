using Interfaces.BaseImpl;
using Interfaces.Example;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IModificators : IExample, IDisplayable //интерфейс может наследоваться только от интерфейса (не от класса)
    {
        public const int minSpeed = 0;     // минимальная скорость
        private static int maxSpeed = 60;   // максимальная скорость
        public void Move(); 
        protected internal string Name { get; set; }    // название
    }
}

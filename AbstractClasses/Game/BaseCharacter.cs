using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Game
{
    public abstract class BaseCharacter
    {
        public void GetGameName()
        {
            Console.WriteLine("Наша игра!");
        }
    }
}

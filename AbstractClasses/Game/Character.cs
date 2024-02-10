using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Game
{
    public abstract class Character : BaseCharacter
    {
        
        public int level;
        public string name;
        
        protected Character(int level)
        
        {
            this.level = level;
        }
        protected Character()
        {

        }
        public abstract void Move();
        public abstract void Attack();
        public abstract void UseAbility();

        public abstract string Clan{ get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"{name} {level}");
        }
    }
}

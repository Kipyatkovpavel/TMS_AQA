using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Game
{
    public class Warrior : Character
    {
        public Warrior(int level) : base(level)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Warrior is moving to...");
        }
        public override void Attack()
        {
            Console.WriteLine("Warrior is attacking you");
        }

        public override void UseAbility()
        {
            Console.WriteLine("Warrior is using kill Ability");
        }
        public override string Clan { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses.Game
{
    public class Wizard : Character
    {
        public Wizard(int level) : base(level)
       {
        }
        public override void Move()
        {
            Console.WriteLine("Wizard is moving to...");
        }

        public override void Attack()
        {
            Console.WriteLine("Wizard is attacking...");
        }

        public override void UseAbility()
        {
            Console.WriteLine("Wizard is using ability to...");
        }
        public override string Clan { get; set; }
    }
}

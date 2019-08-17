using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class IndirectFireWeapon : Weapon
    {
        public IndirectFireWeapon() : base("mortar", "Weeeee~ BOOMM", 5935) { }

        public override void Action()
        {
            Console.WriteLine($"{sound}, a {weapon} round destroyed multiple targets {maxRange} away");
        }
        public void Special()
        {
            Console.WriteLine("It was a splash damage.");
        }
    }
}

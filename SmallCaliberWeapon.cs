using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class SmallCaliberWeapon : Weapon
    {
        public SmallCaliberWeapon() : base("radar speed gun") { }

        public override void Action()
        {
            Console.WriteLine($"with a {weapon} pointing at your car.");
        }
        
    }
}

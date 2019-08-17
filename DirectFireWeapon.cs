using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class DirectFireWeapon : Weapon
    {
        public DirectFireWeapon() : base("Rifle", "tah tah tah", 600) { }

        public void Special()
        {
            Console.WriteLine("It is on BURST!!");
        }
    }
}

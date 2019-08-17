using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class App
    {
        public void Run()
        {
            Mission();
        }

        private static void Mission()
        {
            MilitaryPolice MP = new MilitaryPolice();
            SmallCaliberWeapon M9 = new SmallCaliberWeapon();
            Console.WriteLine("Mission 1:");
            MP.Duty();
            M9.Action();
            MP.Special();
            Console.WriteLine(" ");

            Personnel Infantry = new Personnel();
            DirectFireWeapon M4 = new DirectFireWeapon();
            Console.WriteLine("Mission 2:");
            Infantry.Duty();
            M4.Action();
            M4.Special();
            Console.WriteLine(" ");

            IndirectFireInf IndirectInfantry = new IndirectFireInf();
            IndirectFireWeapon M224 = new IndirectFireWeapon();
            Console.WriteLine("Mission 3:");
            IndirectInfantry.Duty();
            M224.Action();
            M224.Special();
        }    
    }
}

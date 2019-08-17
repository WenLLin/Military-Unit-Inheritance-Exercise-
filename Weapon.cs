using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    abstract class Weapon
    {
        protected readonly string sound;
        protected readonly string weapon;
        protected readonly int maxRange;

        protected Weapon(string weapon)
        {
            this.weapon = weapon;
        }
        protected Weapon(string weapon ,string sound, int maxRange)
        {
            this.weapon = weapon;
            this.sound = sound;
            this.maxRange = maxRange;
        }

        public virtual void Action()
        {
            Console.WriteLine($"{weapon} goes {sound} at a target {maxRange} meters away.");
        }
        

       
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class IndirectFireInf : Personnel
    {
        public IndirectFireInf() : base("male", "King", "Indirect Fire Infantryman", "SGT") {}

        public override void Duty()
        {
            Console.WriteLine($"A {gender} {mos}, {rank} {name} is firing a mortar, ");
        }
    }
}

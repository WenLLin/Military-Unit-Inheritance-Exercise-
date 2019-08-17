using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class MilitaryPolice : Personnel
    {
        public MilitaryPolice() : base("female", "Ponce", "Military Police", "SPC") {}

        public override void Duty()
        {
            Console.WriteLine($"A {gender} {mos}, {rank} {name} is hiding on the side of a road ");
        }
        public void Special()
        {
            if (gender == "female")
            {
                Console.WriteLine("3 MPH over the speed limit, she is going to give you ticket.");
            }
            else if (gender == "male")
            {
                Console.WriteLine("3 MPH over the speed limit, he is going to give you ticket.");
            }
            else
            {
                Console.WriteLine("3 MPH over the speed limit, you will be issued a ticket.");
            }

        }
    }
}

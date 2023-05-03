using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        //Overrides the cost
        public override float Cost => 5.0f;

        //Movement 1 and Health 2
        public SettlerUnit() : base(1, 2)
        {
        }

        //Distance calculator
        public override void Move(int distance)
        {
            //Distance
            Console.WriteLine($"SettlerUnit moved {distance} tiles.");
        }
    }
}

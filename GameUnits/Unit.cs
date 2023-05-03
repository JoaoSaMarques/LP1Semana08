using System;

namespace GameUnits
{
    class Program
    {
        public abstract class Unit
        {
            private int movement;

            public int Health { get; set; }

            public abstract float Cost { get; }
        }
    }
}

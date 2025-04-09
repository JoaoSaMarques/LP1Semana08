using System;
using System.Globalization;

namespace GameUnit
{
    public class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            var romanFormat = new NumberFormatInfo
            {
                NumberRomanNumeral = true
            };
            Console.WriteLine($"Unit moved {movement.ToString("N", romanFormat)} spaces");
        }

        public abstract float Cost { get; }
    }
}

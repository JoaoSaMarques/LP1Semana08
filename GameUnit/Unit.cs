using System;
using Humanizer

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
            Console.WriteLine($"Unit moved {movement.ToRoman()} spaces");
        }

        public abstract float Cost { get; }
    }
}

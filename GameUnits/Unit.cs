﻿using System;

namespace GameUnits
{
    public abstract class Unit
    {
        //Movement
        private int movement;

        //Health
        public int Health { get; set; }

        //Cost
        public abstract float Cost { get; }

        //Movement distance
        public virtual void Move(int distance)
        {
            Console.WriteLine($"Unit moved {distance} tiles.");
        }

        public abstract void Attack(Unit unit);
        
        //Unit constructor
        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        //Override string
        public override string ToString()
        {
            return $"{GetType().Name}: HP={Health} COST={Cost:F2}";
        }
    }
}
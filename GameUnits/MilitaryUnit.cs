using System;

namespace GameUnits
{
    public class MilitaryUnit : XPUnit
    {
        //Strength of attacks
        public int AttackPower { get; }

        //Override cost to Strength + xp
        public override float Cost => AttackPower + XP;

        //Constructor
        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            //Attack Power
            AttackPower = attackPower;
        }

        //Calculate distance when moving
        public override void Move(int distance)
        {
            //Distance of movement
            Console.WriteLine($"MilitaryUnit moved {distance} tiles.");
        }

        //Attack
        public override void Attack(Unit unit)
        {
            if (unit is MilitaryUnit)
            {
                MilitaryUnit enemy = unit as MilitaryUnit;
                int damage = Math.Min(AttackPower, enemy.Health);
                enemy.Health -= damage;
                XP += damage;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={XP}";
        }
    }
}

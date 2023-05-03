using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit, IAttackable
    {
        //Strength of attacks
        public int AttackPower { get; }

        //Xp of unit
        public int XP { get; private set; }

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
        public void Attack(Unit unit)
        {
            //Damage taken translates to health - attack strength
            unit.Health -= AttackPower;
            //Gain xp when hitting
            XP++;
        }
    }
}

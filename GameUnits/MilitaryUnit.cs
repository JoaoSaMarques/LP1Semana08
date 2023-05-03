using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        //Strength of attacks
        public int AttackPower { get; }

        //Xp of unit
        public int XP { get; private set; }

        //Override cost to Strength + xp
        public override float Cost => AttackPower + XP;
    }
}

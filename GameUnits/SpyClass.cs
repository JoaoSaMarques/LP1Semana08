using System;

namespace GameUnits
{
    public abstract class SpyClass : XPUnit
    {
        //Override the cost of Unit
        public override float Cost => 12.5f;

        //Get secret information
        public void GetSecretInfo(Unit unit)
        {
            //If it engages with a spy unit
            if (unit is SpyUnit)
            {
                //XP goes up by 3
                XP += 3;
            }
            //If it engages with military unit then XP raises by 2
            else if (unit is MilitaryUnit)
            {
                //XP goes up by 2
                XP += 2;
            }
            //Otherwise if it's everything else(Like settler, +1 xp)
            else
            {
                //XP goes up by 1
                XP += 1;
            }
        }
    }
}
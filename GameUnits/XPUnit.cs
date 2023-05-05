using System;

namespace GameUnits
{
    public abstract class XPUnit : Unit
    {
        //XP
        public int XP { get; protected set; }

        //Constructor
        public XPUnit(int movement, int health) : base(movement, health)
        {
            //Set XP value
            XP = 0;
        }
    }
}
using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        //Overrides the cost
        public override float Cost => 5;
    }

    public SettlerUnit() : base(1, 2)
    {
    }
}

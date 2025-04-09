namespace GameUnit
{
    public class SettlerUnit : Unit // Heranca!!
    {
        public SettlerUnit() : base(1, 3)
        {                                         // movement = 1, health = 3
        }

        public override float Cost => 5; // Fixed cost of 5
    }
}

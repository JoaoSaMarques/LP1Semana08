namespace GameUnit
{
    public class SettlerUnit : Unit // Heranca!!
    {
        public int XP { get; private set; }

        public SettlerUnit(int mov, int health) : base(mov, health)
        {                                                        // Unit(int, int)
            XP = 0;
        }

        public override float Cost => 5;
    }
}

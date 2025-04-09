namespace GameUnit
{
    public class SettlerUnit : Unit // Heranca!!
    {
        public SettlerUnit(int mov, int health) : base(mov, health)
        {                                                        // Unit(int, int)
            movement = 1;
            health = 3;

        }

        public override float Cost => 5;
    }
}

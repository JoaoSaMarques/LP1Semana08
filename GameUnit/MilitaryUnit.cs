namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health => base.Health + XP;

        public override float Cost => AttackPower + XP;

        public void Attack(Unit target)
        {
            XP++;
            target.Health -= AttackPower;
        }
    }
}

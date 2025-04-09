namespace GameUnit
{
    public class Unit
    {
        private readonly int movement;
        public int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public int Move { get { return movement;}}

        public float Cost { get; }
    }
}

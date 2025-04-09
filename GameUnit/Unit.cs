namespace GameUnit
{
    public class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            string roman = ConvertToRoman(movement);
            Console.WriteLine($"Unit moved {roman} spaces");
        }

        public float Cost { get;}
    }
}

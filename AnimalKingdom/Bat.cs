namespace AnimalKingdom
{
    public class Bat : Animal, ICanFly, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Shree";
        }

        public int NumberOfWings { get;} = 2;

        public int NumberOfNipples { get;} = 2;
    }
}

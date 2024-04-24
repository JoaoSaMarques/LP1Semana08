namespace AnimalKingdom
{
    public class Bat : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Shree";
        }

        public int NumberOfWings { get;} = 2;
    }
}

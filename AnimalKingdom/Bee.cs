namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzzz";
        }

        public int NumberOfWings { get;} = 4;
    }
}

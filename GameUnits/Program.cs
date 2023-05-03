using System;

namespace GameUnits
{
    class Program
{
    static void Main(string[] args)
    {
        Unit unit1 = new MilitaryUnit(2, 10, 5);
        Unit unit2 = new SettlerUnit();

        //Unit 1 movement + health + cost
        unit1.Move(3);
        Console.WriteLine($"Unit 1 Health: {unit1.Health}");
        Console.WriteLine($"Unit 1 Cost: {unit1.Cost}");

        //Unit 2 movement + health + cost
        unit2.Move(2);
        Console.WriteLine($"Unit 2 Health: {unit2.Health}");
        Console.WriteLine($"Unit 2 Cost: {unit2.Cost}");
    }
}
}

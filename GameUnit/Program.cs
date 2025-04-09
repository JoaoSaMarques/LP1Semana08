using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Test MilitaryUnit
            var soldier = new MilitaryUnit(2, 10, 3);
            Console.WriteLine("Testing MilitaryUnit:");
            soldier.Move();
            Console.WriteLine($"Health: {soldier.Health}");
            Console.WriteLine($"Cost: {soldier.Cost}");
        }
    }
}

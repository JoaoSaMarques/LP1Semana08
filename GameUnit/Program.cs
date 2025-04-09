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

            // Test attack
            var target = new MilitaryUnit(1, 5, 1);
            soldier.Attack(target);
            Console.WriteLine($"After attack - Soldier XP: {soldier.XP}");
            Console.WriteLine($"Target Health: {target.Health}");

            // Test SettlerUnit
            var settler = new SettlerUnit();
            Console.WriteLine("\nTesting SettlerUnit:");
            settler.Move();
            Console.WriteLine($"Health: {settler.Health}");
            Console.WriteLine($"Cost: {settler.Cost}");
        }
    }
}

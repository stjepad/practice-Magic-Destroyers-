using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;


namespace MagicDestroyers
{
    public class EntryPoint
    {
        static void Main()
        {
            //Warrior defaults
            Warrior firstWarrior = new Warrior();
            Warrior.GetDefaultValues(firstWarrior);


            //Assassin defaults
            Assassin firstAssassin = new Assassin();
            firstAssassin.HealthPoints = 24;
            firstAssassin.AbilityPoints = 14;
            Assassin.GetDefaultValues(firstAssassin);

            Console.WriteLine($"Overridden Health Points work {firstAssassin.HealthPoints}");
            Console.WriteLine($"Overridden Ability Points work {firstAssassin.AbilityPoints}");

            //Knight defaults
            Knight firstKnight = new Knight();
            firstKnight.Level = 23;
            
            Knight.GetDefaultValues(firstKnight);

            Console.WriteLine($"Overridden Level works { firstKnight.Level}");

            // Druid defaults
            Druid firstDruid = new Druid();
            Druid.GetDefaultValues(firstDruid);
            firstDruid.ManaPoints = 13;
            Console.WriteLine($"Overridden Druid Mana points works {firstDruid.ManaPoints}");

            Mage firstMage = new Mage();
            Mage.GetDefaultValues(firstMage);
            firstMage.ManaPoints = 22;
            Console.WriteLine($"Overridden Mage Mana points {firstMage.ManaPoints}");

            Necromancer firstNecromancer = new Necromancer();
            Necromancer.GetDefaultValues(firstNecromancer);
            firstNecromancer.ManaPoints = 13;
            Console.WriteLine(firstNecromancer.ManaPoints);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

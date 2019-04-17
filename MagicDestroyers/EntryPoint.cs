using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;

namespace MagicDestroyers
{
    public class EntryPoint
    {
        static void Main()
        {
            ////Warrior defaults
            //Warrior firstWarrior = new Warrior();
            //Warrior.GetDefaultValues(firstWarrior);


            ////Assassin defaults
            //Assassin firstAssassin = new Assassin();
            //firstAssassin.HealthPoints = 24;
            //firstAssassin.AbilityPoints = 14;
            //Assassin.GetDefaultValues(firstAssassin);

            //Console.WriteLine($"Overridden Health Points work {firstAssassin.HealthPoints}");
            //Console.WriteLine($"Overridden Ability Points work {firstAssassin.AbilityPoints}");

            ////Knight defaults
            //Knight firstKnight = new Knight();
            //firstKnight.Level = 23;

            //Knight.GetDefaultValues(firstKnight);

            //Console.WriteLine($"Overridden Level works { firstKnight.Level}");

            //// Druid defaults
            //Druid firstDruid = new Druid();
            //Druid.GetDefaultValues(firstDruid);
            //firstDruid.ManaPoints = 13;
            //Console.WriteLine($"Overridden Druid Mana points works {firstDruid.ManaPoints}");

            //Mage firstMage = new Mage();
            //Mage.GetDefaultValues(firstMage);
            //firstMage.ManaPoints = 22;
            //Console.WriteLine($"Overridden Mage Mana points {firstMage.ManaPoints}");

            //Necromancer firstNecromancer = new Necromancer();
            //Necromancer.GetDefaultValues(firstNecromancer);
            //firstNecromancer.ManaPoints = 13;
            //Console.WriteLine(firstNecromancer.ManaPoints);


            ////Initialize all basetype characters
            ////Character warrior = new Warrior();
            ////Character knight = new Knight();
            ////Character assassin = new Assassin();
            ////Character mage = new Mage();
            ////Character necromancer = new Necromancer();
            ////Character druid = new Druid();


            // Actual game logic starts here 
            Random rng = new Random();

            int currentMelee = 0;
            int currentSpellcaster = 0;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
                {
                    new Warrior(),
                    new Warrior(),
                    new Warrior(),
                    //new Assassin(),
                    //new Knight(),

                    //new Druid(),
                    new Mage(),
                    new Mage(),
                    new Mage(),
                    //new Necromancer()

                };

            //Create lists of 2 teams here
            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            //Add specific character to their designated teams
            foreach (var character in characters)
            {
                if ( character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster) character);
                };
            }

            while (!gameOver)
            {
                // 1. take a random melee character
                currentMelee = rng.Next(0, meleeTeam.Count);
                // 2. take a random spellcaster character
                currentSpellcaster = rng.Next(0, spellTeam.Count);

                // 3. melee attacks spellcaster
                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].Attack(), meleeTeam[currentMelee].Name );
                // 3.1 check if the character died and remove him from the team.
                // 3.2 if dead, get another character from the team.
                if (!spellTeam[currentSpellcaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellTeam.Remove(spellTeam[currentSpellcaster]);

                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                    currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }
                }

                // 4. spellcaster attacks melee
                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].Attack(), spellTeam[currentSpellcaster].Name );
                // 4.1 check if the character died and remove him from the team.
                // 4.2 if dead, get another character from the team.

                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);
                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcaster team wins!");
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }

                // If no characters are alive from either of the teams gameOver = true
            }





            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

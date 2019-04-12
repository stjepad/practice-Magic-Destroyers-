using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;


namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        // Constant default properties
        private const int DEFAULT_ABILITYPOINTS = 7;
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_HEALTHPOINTS = 10;
        private const int DEFAULT_LEVEL = 7;
        private const string DEFAULT_NAME = "Default Warrior Name";

        private readonly Chainlink DEFAULT_BODYARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        //Private properites
       
        private Chainlink bodyArmor;
        private Axe weapon;


        //body armor properties
        public Chainlink BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                    this.bodyArmor = value;
            }
        }

        //Weapon properties
        public Axe Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        // Start Chain Constructor here!
        //Constructor 1
        public Warrior()
            : this(DEFAULT_ABILITYPOINTS, DEFAULT_FACTION)
        {

        }
        
        // Constructor 2
        public Warrior(int abilityPoints, Faction faction)
            : this(abilityPoints, faction, DEFAULT_HEALTHPOINTS)
        {

        }

        // Constructor 3
        public Warrior(int abilityPoints, Faction faction, int healthPoints)
            : this(abilityPoints, faction, healthPoints, DEFAULT_LEVEL)
        {

        }

        //Constructor 4
        public Warrior(int abilityPoints, Faction faction, int healhPoints, int level)
            : this(abilityPoints, faction, healhPoints, level, DEFAULT_NAME)
        {

        }

        //Constructor 5
        public Warrior(int abilityPoints, Faction faction, int healthPoints, int level, string name)
        {
            base.AbilityPoints = abilityPoints;
            base.Faction = faction;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Name = name;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }

        
        //Abilities
        public void Strike()
        {
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void SkinHarden()
        {
            throw new NotImplementedException();
        }

        //General default detail constructor console.writeline to see if info is being processed correctly.
        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($@"WARRIOR WORKS! INHERITANCE" +
                $"\nDefault Ability Points: {DEFAULT_ABILITYPOINTS} " +
                $"\nDefault Faction: {DEFAULT_FACTION} " +
                $"\nDefault Name: {DEFAULT_NAME} " +
                $"\nDefault Health Points: {DEFAULT_HEALTHPOINTS} " +
                $"\nDefault Level: {DEFAULT_LEVEL} " +
                $"\nDedault Weapon Damage: {warrior.DEFAULT_WEAPON.Damage}" +
                $"\nDedault Body Armor Points: {warrior.DEFAULT_BODYARMOR.ArmorPoints}" +
                $"\n");
        }
    }
}

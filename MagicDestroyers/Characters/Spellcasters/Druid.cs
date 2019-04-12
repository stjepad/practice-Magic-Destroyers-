using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
   public class Druid : Spellcaster
    {
        // Character Default stats for comparison
        // level = up to 25
        // healthPoints = 20
        //abilityPoints = 10

        // constant default properties 
        private const int DEFAULT_MANAPOINTS = 6;
        private const Faction DEFAULT_FACTION = Enumerations.Faction.Spellcaster;
        private const int DEFAULT_HEALTHPOINTS = 4;
        private const int DEFAULT_LEVEL = 6;
        private const string DEFAULT_NAME = "Default Druid Name";

        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();
        //private properties
        private int manaPoints;
        private LightLeatherVest bodyArmor;
        private Staff weapon;

        //Ability Points properties
        public override int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 13)
                {
                    this.manaPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 13.");
            }
        }

        //body armor properties
        public LightLeatherVest BodyArmor
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
        public Staff Weapon
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

        // Start Chain Constructor here
        //Constructor
        public Druid()
            : this(DEFAULT_MANAPOINTS, DEFAULT_FACTION)
        {

        }

        // Contructor 2
        public Druid(int abilityPoints, Faction faction)
            : this(abilityPoints, faction, DEFAULT_HEALTHPOINTS)
        {

        }

        // Constructor 3
        public Druid(int abilityPoints,Faction faction, int healthPoints)
            : this(abilityPoints, faction, healthPoints, DEFAULT_LEVEL)
        {

        }

        // Constructor 4
        public Druid(int abilityPoints, Faction faction, int healthPoints, int level)
            : this(abilityPoints, faction, healthPoints, level, DEFAULT_NAME)
        {

        }

        // Constructor 5
        public Druid(int abilityPoints, Faction faction, int healthPoints, int level, string name)
        {
            ManaPoints = abilityPoints;
            Faction = faction;
            HealthPoints = healthPoints;
            Level = level;
            Name = name;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }

        //Abilities
        public void Moonfire()
        {
            throw new NotImplementedException();
        }
        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithTheNature()
        {
            throw new NotImplementedException();
        }

        public static void GetDefaultValues(Druid druid)
        {
            Console.WriteLine($@"DRUID WORKS! INHERITANCE" +
                $"\nDefault Mana Points: {DEFAULT_MANAPOINTS} " +
                $"\nDefault Faction: {DEFAULT_FACTION} " +
                $"\nDefault Name: {DEFAULT_NAME} " +
                $"\nDefault Health Points: {DEFAULT_HEALTHPOINTS} " +
                $"\nDefault Level: {DEFAULT_LEVEL} " +
                $"\nDedault Weapon Damage: {druid.DEFAULT_WEAPON.Damage}" +
                $"\nDedault Body Armor Points: {druid.DEFAULT_BODYARMOR.ArmorPoints}" +
                $"\n ");
        }
    }
}

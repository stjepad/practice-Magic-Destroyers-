using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
   public class Mage : Spellcaster
    {// Character Default stats for comparison
        // level = up to 25
        // healthPoints = 20
        //abilityPoints = 10

        // constant default properties
        private const int DEFAULT_MANAPOINTS = 15;
        private const Faction DEFAULT_FACTION = Enumerations.Faction.Spellcaster;
        private const int DEFAULT_HEALTHPOINTS = 7;
        private const int DEFAULT_LEVEL = 16;
        private const string DEFAULT_NAME = "Default Mage Name";

        private readonly ClothRobe DEFAULT_BODYARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        // private properties
        private int manaPoints;
       
        private ClothRobe bodyArmor;
        private Staff weapon;

        // Mana Points properties
        public override int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    this.manaPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 23.");
            }
        }

        //body armor properties
        public ClothRobe BodyArmor
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
        //Constructor 1
        public Mage()
            : this(DEFAULT_MANAPOINTS, DEFAULT_FACTION)
        {

        }

        //Constructor 2
        public Mage(int abilityPoints, Faction faction)
            : this(abilityPoints, faction, DEFAULT_HEALTHPOINTS)
        {

        }

        //Constructor 3
        public Mage(int abilityPoints, Faction faction, int healthPoints)
            : this(abilityPoints, faction, healthPoints, DEFAULT_LEVEL)
        {

        }

        //Constructor 4
        public Mage(int abilityPoints, Faction faction, int healthPoints, int level)
            : this(abilityPoints, faction, healthPoints, level, DEFAULT_NAME)
        {

        }

        //Constructor 5
        public Mage(int abilityPoints, Faction faction, int healthPoints, int level, string name)
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
        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }
        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }

        //General default detail constructor console.writeline to see if info is being processed correctly.
        public static void GetDefaultValues(Mage mage)
        {
            Console.WriteLine($@"MAGE WORKS! INHERITANCE" +
                $"\nDefault Ability Points: {DEFAULT_MANAPOINTS} " +
                $"\nDefault Faction: {DEFAULT_FACTION} " +
                $"\nDefault Name: {DEFAULT_NAME} " +
                $"\nDefault Health Points: {DEFAULT_HEALTHPOINTS} " +
                $"\nDefault Level: {DEFAULT_LEVEL} " +
                $"\nDedault Weapon Damage: {mage.DEFAULT_WEAPON.Damage}" +
                $"\nDedault Body Armor Points: {mage.DEFAULT_BODYARMOR.ArmorPoints}" +
                $"\n");
        }
    }
}

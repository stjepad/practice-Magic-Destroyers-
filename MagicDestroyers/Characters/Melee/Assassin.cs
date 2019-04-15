using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        // Character Default stats for comparison
        // level = up to 25
        // healthPoints = 20
        //abilityPoints = 10

        // Constant default properties
        private const int DEFAULT_ABILITYPOINTS = 5;
        private const Faction DEFAULT_FACTION = Enumerations.Faction.Melee;
        private const int DEFAULT_HEALTHPOINTS = 15;
        private const int DEFAULT_LEVEL = 11;
        private const string DEFAULT_NAME = "Default Assassin Name";

        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();


        //Private properties
        private int abilityPoints;
        private int healthPoints;

        private LightLeatherVest bodyArmor;
        private Sword weapon;

        // Ability Points Properties
        public override int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 15)
                {
                    this.abilityPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 15.");
            }
        }

        //// Health Points Properties
        public override int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 25)
                {
                    this.healthPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 25.");
            }
        }

        // Armor Properties
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

        // Weapon Properties
        public Sword Weapon
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
        public Assassin()
            : this(DEFAULT_ABILITYPOINTS, DEFAULT_FACTION)
        {

        }

        // Constructor 2
        public Assassin(int ablilityPoints, Faction faction)
            : this(ablilityPoints, faction, DEFAULT_HEALTHPOINTS)
        {

        }

        // Constructor 3
        public Assassin(int abilityPoints, Faction faction, int healthPoints)
            : this(abilityPoints, faction, healthPoints, DEFAULT_LEVEL)
        {

        }

        // Constructor 4
        public Assassin(int abilityPoints, Faction faction, int healthPoints, int level )
            : this(abilityPoints, faction, healthPoints, level, DEFAULT_NAME)
        {

        }

        // Constructor 5
        public Assassin(int abilityPoints, Faction faction, int healthPoints, int level, string name)
        {
            AbilityPoints = abilityPoints;
            Faction = faction;
            HealthPoints = healthPoints;
            Level = level;
            Name = name;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }


        public static void GetDefaultValues(Assassin assassin)
        {
            Console.WriteLine($@"ASSASSIN WORKS! INHERITANCE" +
                $"\nDefault Ability Points: {DEFAULT_ABILITYPOINTS} " +
                $"\nDefault Faction: {DEFAULT_FACTION} " +
                $"\nDefault Name: {DEFAULT_NAME} " +
                $"\nDefault Health Points: {DEFAULT_HEALTHPOINTS} " +
                $"\nDefault Level: {DEFAULT_LEVEL} " +
                $"\nDedault Weapon Damage: {assassin.DEFAULT_WEAPON.Damage}" +
                $"\nDedault Body Armor Points: {assassin.DEFAULT_BODYARMOR.ArmorPoints}" +
                $"\n ");
        }

        //Abilities
        public void Raze()
        {
            throw new NotImplementedException();
        }
        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
        // Implemented Abstract Attack Methods
        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }
        //Implemented Abstract Defense Method
        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }
}

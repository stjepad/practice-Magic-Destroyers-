using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        // Character Default stats for comparison
        // level = up to 25
        // healthPoints = 20
        //abilityPoints = 10

        //Constant Default Properties
        private const int DEFAULT_ABILITYPOINTS = 4;
        private const Faction DEFAULT_FACTION = Enumerations.Faction.Melee;
        private const int DEFAULT_HEALTHPOINTS = 22;
        private const int DEFAULT_LEVEL = 12;
        private const string DEFAULT_NAME = "Default Knight Name";

        private readonly Chainlink DEFAULT_BODYARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        //Private Properties
        private int level;
        private int healthPoints;

        private Chainlink bodyArmor;
        private Hammer weapon;

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

        //Level Properties
        public override int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 23)
                {
                    this.level = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 23.");
            }
        }

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
        public Hammer Weapon
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


        // Start chain constructor here
        //Constructor 1
        public Knight()
            : this(DEFAULT_ABILITYPOINTS, DEFAULT_FACTION)
        {

        }

        // Constructor 2
        public Knight(int abilityPoints, Faction faction)
            : this(abilityPoints, faction, DEFAULT_HEALTHPOINTS)
        {

        }

        // Constructor 3 
        public Knight(int abilityPoints, Faction faction, int healthPoints)
            : this (abilityPoints, faction, healthPoints, DEFAULT_LEVEL)
        {

        }

        // Constructor 4
        public Knight(int abilityPoints, Faction faction, int healthPoints, int level)
            : this (abilityPoints, faction, healthPoints, level, DEFAULT_NAME)
        {

        }

        // Constructor 5
        public Knight(int abilityPoints, Faction faction, int healthPoints, int level, string name)
        {
            AbilityPoints = abilityPoints;
            Faction = faction;
            HealthPoints = healthPoints;
            Level = level;
            Name = name;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODYARMOR;
        }

        public static void GetDefaultValues(Knight knight)
        {
            Console.WriteLine($@"KNIGHT WORKS! INHERITANCE" +
                $"\nDefault Ability Points: {DEFAULT_ABILITYPOINTS} " +
                $"\nDefault Faction: {DEFAULT_FACTION} " +
                $"\nDefault Name: {DEFAULT_NAME} " +
                $"\nDefault Health Points: {DEFAULT_HEALTHPOINTS} " +
                $"\nDefault Level: {DEFAULT_LEVEL} " +
                $"\nDedault Weapon Damage: {knight.DEFAULT_WEAPON.Damage}" +
                $"\nDedault Body Armor Points: {knight.DEFAULT_BODYARMOR.ArmorPoints}" +
                $"\n ");
        }

        //Abilities
        public void HolyBlow()
        {
            throw new NotImplementedException();
        }
        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
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

using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
   public class Mage : Spellcaster
    {
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
            : this(Consts.Mage.DEFAULT_MANAPOINTS, Consts.Mage.DEFAULT_FACTION)
        {

        }

        //Constructor 2
        public Mage(int abilityPoints, Faction faction)
            : this(abilityPoints, faction, Consts.Mage.DEFAULT_HEALTHPOINTS)
        {

        }

        //Constructor 3
        public Mage(int abilityPoints, Faction faction, int healthPoints)
            : this(abilityPoints, faction, healthPoints, Consts.Mage.DEFAULT_LEVEL)
        {

        }

        //Constructor 4
        public Mage(int abilityPoints, Faction faction, int healthPoints, int level)
            : this(abilityPoints, faction, healthPoints, level, Consts.Mage.DEFAULT_NAME)
        {

        }

        //Constructor 5
        public Mage(int abilityPoints, Faction faction, int healthPoints, int level, string name)
        {
            base.ManaPoints = abilityPoints;
            base.Faction = faction;
            base.HealthPoints = healthPoints;
            base.Level = level;
            base.Name = name;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }

        //General default detail constructor console.writeline to see if info is being processed correctly.
        public static void GetDefaultValues(Mage mage)
        {
            Console.WriteLine($@"MAGE WORKS! INHERITANCE" +
                $"\nDefault Ability Points: {Consts.Mage.DEFAULT_MANAPOINTS} " +
                $"\nDefault Faction: {Consts.Mage.DEFAULT_FACTION} " +
                $"\nDefault Name: {Consts.Mage.DEFAULT_NAME} " +
                $"\nDefault Health Points: {Consts.Mage.DEFAULT_HEALTHPOINTS} " +
                $"\nDefault Level: {Consts.Mage.DEFAULT_LEVEL} " +
                $"\nDedault Weapon Damage: {mage.DEFAULT_WEAPON.DamagePoints}" +
                $"\nDedault Body Armor Points: {mage.DEFAULT_BODYARMOR.ArmorPoints}" +
                $"\n");
        }

        //Abilities
        public int ArcaneWrath()
        {
            return base.Weapon.DamagePoints + 4; 
        }
        public int Firewall()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 3;
        }
        // Implemented Abstract Attack Methods
        public override int Attack()
        {
            return this.ArcaneWrath();
        }

        public override int  SpecialAttack()
        {
            return this.Firewall();
        }

        //Implemented Abstract Defense Method
        public override int Defend()
        {
            return this.Meditation();
        }
    }
}

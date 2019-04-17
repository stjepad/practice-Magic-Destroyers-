using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;


namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        // Constant default properties
       

        private readonly Chainlink DEFAULT_BODYARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

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
            : this(Consts.Warrior.DEFAULT_ABILITYPOINTS, Consts.Mage.DEFAULT_FACTION)
        {

        }
        
        // Constructor 2
        public Warrior(int abilityPoints, Faction faction)
            : this(abilityPoints, faction, Consts.Warrior.DEFAULT_HEALTHPOINTS)
        {

        }

        // Constructor 3
        public Warrior(int abilityPoints, Faction faction, int healthPoints)
            : this(abilityPoints, faction, healthPoints, Consts.Warrior.DEFAULT_LEVEL)
        {

        }

        //Constructor 4
        public Warrior(int abilityPoints, Faction faction, int healhPoints, int level)
            : this(abilityPoints, faction, healhPoints, level, Consts.Warrior.DEFAULT_NAME)
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
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }

        
        //General default detail constructor console.writeline to see if info is being processed correctly.
        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine($@"WARRIOR WORKS! INHERITANCE" +
                $"\nDefault Ability Points: {Consts.Warrior.DEFAULT_ABILITYPOINTS} " +
                $"\nDefault Faction: {Consts.Warrior.DEFAULT_FACTION} " +
                $"\nDefault Name: {Consts.Warrior.DEFAULT_NAME} " +
                $"\nDefault Health Points: {Consts.Warrior.DEFAULT_HEALTHPOINTS} " +
                $"\nDefault Level: {Consts.Warrior.DEFAULT_LEVEL} " +
                $"\nDedault Weapon Damage: {warrior.DEFAULT_WEAPON.DamagePoints}" +
                $"\nDedault Body Armor Points: {warrior.DEFAULT_BODYARMOR.ArmorPoints}" +
                $"\n");
        }



        //Abilities
        public int Strike()
        {
            return base.DamagePoints + 4;
        }
        public int Execute()
        {
            throw new NotImplementedException();
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 2;
        }

        // Implemented Abstract Attack Methods
        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        //Implemented Abstract Defense Method
        public override int Defend()
        {
           return this.SkinHarden();
        }
    }
}

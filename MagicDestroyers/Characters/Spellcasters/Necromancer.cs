//using MagicDestroyers.Enumerations;
//using MagicDestroyers.Equipment.Armors.Leather;
//using MagicDestroyers.Equipment.Weapons.Sharp;
//using System;

//namespace MagicDestroyers.Characters.Spellcasters
//{
//    public class Necromancer : Spellcaster
//    {
//        // Character Default stats for comparison
//        // level = up to 25
//        // healthPoints = 20
//        //abilityPoints = 10

//        // constant default properties
//        private const int DEFAULT_MANAPOINTS = 11;
//        private const Faction DEFAULT_FACTION = Enumerations.Faction.Spellcaster;
//        private const int DEFAULT_HEALTHPOINTS = 5;
//        private const int DEFAULT_LEVEL = 9;
//        private const string DEFAULT_NAME = "Default Necromancer Name";

//        private readonly LightLeatherVest DEFAULT_BODYARMOR = new LightLeatherVest();
//        private readonly Sword DEFAULT_WEAPON = new Sword();


//        //private properties
//        private int manaPoints;
        
//        private LightLeatherVest bodyArmor;
//        private Sword weapon;

//        //Ability points properties
//        public override int ManaPoints
//        {
//            get
//            {
//                return this.manaPoints;
//            }
//            set
//            {
//                if (value >= 0 && value <= 14)
//                {
//                    this.manaPoints = value;
//                }
//                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 14.");
//            }
//        }

//        //body armor properties
//        public LightLeatherVest BodyArmor
//        {
//            get
//            {
//                return this.bodyArmor;
//            }
//            set
//            {
//                this.bodyArmor = value;
//            }
//        }


//        //Weapon properties
//        public Sword Weapon
//        {
//            get
//            {
//                return this.weapon;
//            }
//            set
//            {
//                this.weapon = value;
//            }
//        }

//        // Start Chain Constructor here
//        //Constructor
//        public Necromancer()
//            : this(DEFAULT_MANAPOINTS, DEFAULT_FACTION)
//        {

//        }

//        //Constructor 2
//        public Necromancer(int manaPoints, Faction faction)
//            : this(manaPoints, faction, DEFAULT_HEALTHPOINTS)
//        {

//        }

//        //Constructor 3
//        public Necromancer(int manaPoints, Faction faction, int healthPoints)
//            : this(manaPoints, faction, healthPoints, DEFAULT_LEVEL)
//        {

//        }

//        //Constructor 4
//        public Necromancer(int manaPoints, Faction faction, int healthPoints, int level)
//            : this(manaPoints, faction, healthPoints, level, DEFAULT_NAME)
//        {

//        }

//        //Constructor 5
//        public Necromancer(int manaPoints, Faction faction, int healthPoints, int level, string name)
//        {
//            ManaPoints = manaPoints;
//            Faction = faction;
//            HealthPoints = healthPoints;
//            Level = level;
//            Name = name;
//            this.Weapon = DEFAULT_WEAPON;
//            this.BodyArmor = DEFAULT_BODYARMOR;
//        }


//        public static void GetDefaultValues(Necromancer necromancer)
//        {
//            Console.WriteLine($@"MAGE WORKS! INHERITANCE" +
//                $"\nDefault Ability Points: {DEFAULT_MANAPOINTS} " +
//                $"\nDefault Faction: {DEFAULT_FACTION} " +
//                $"\nDefault Name: {DEFAULT_NAME} " +
//                $"\nDefault Health Points: {DEFAULT_HEALTHPOINTS} " +
//                $"\nDefault Level: {DEFAULT_LEVEL} " +
//                $"\nDedault Weapon Damage: {necromancer.DEFAULT_WEAPON.Damage}" +
//                $"\nDedault Body Armor Points: {necromancer.DEFAULT_BODYARMOR.ArmorPoints}" +
//                $"\n");
//        }

//        //Abilities
//        public void ShadowRage()
//        {
//            throw new NotImplementedException();
//        }
//        public void VampireTouch()
//        {
//            throw new NotImplementedException();
//        }

//        public void BoneShield()
//        {
//            throw new NotImplementedException();
//        }

//        // Implemented Abstract Attack Methods
//        public override void Attack()
//        {
//            this.ShadowRage();
//        }

//        public override void SpecialAttack()
//        {
//            this.VampireTouch();
//        }
//        //Implemented Abstract Defense Method
//        public override void Defend()
//        {
//            this.BoneShield();
//        }
//    }
//}

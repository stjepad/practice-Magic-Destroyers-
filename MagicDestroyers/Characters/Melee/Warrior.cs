using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;


namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Chainlink bodyArmor;
        private Axe weapon;

        //Ability points properties
        public int AblilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
            }
        }

        //Faction properties
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Melee" || value == "Spellcaster")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "the faction should be either Melee or Spellcaster");
                        }
            }
        }

        //HealthPoints properties
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.healthPoints = value;
                }
            else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 20.");
            }
    }

        //Level Properties
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 25)
                {
                    this.level = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 25.");
            }
        }

        //name Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 20)
                {
                    this.name = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 20");
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

        //Constructor 1
        public Warrior()
            : this(10, "Melee")
        {

        }
        
        // Constructor 2
        public Warrior(int abilityPoints, string faction)
            : this(abilityPoints, faction, 20)
        {

        }

        // Constructor 3
        public Warrior(int abilityPoints, string faction, int healthPoints)
            : this(abilityPoints, faction, healthPoints, 10)
        {

        }

        //Constructor 4
        public Warrior(int abilityPoints, string faction, int healhPoints, int level)
            : this(abilityPoints, faction, healhPoints, level, "Regular Warrior")
        {

        }

        //Constructor 5
        public Warrior(int abilityPoints, string faction, int healthPoints, int level, string name)
        {
            AblilityPoints = abilityPoints;
            Faction = faction;
            HealthPoints = healthPoints;
            Level = level;
            Name = name;
            this.Weapon = new Axe();
            this.BodyArmor = new Chainlink();
        }

        //// Constructor
        //public Warrior()
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
    }
}

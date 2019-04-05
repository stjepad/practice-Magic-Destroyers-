using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
   public class Druid
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor;
        private Staff weapon;

        //Ability Points properties
        public int AblilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 13)
                {
                    this.abilityPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 13.");
            }
        }

        // Faction properties
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

        // Health Points properties
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 14)
                {
                    this.healthPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 14.");
            }
        }

        // Level properties
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 17)
                {
                    this.level = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 17.");
            }
        }

        // Name properties
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
        //Constructor
        public Druid()
        {

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


    }
}

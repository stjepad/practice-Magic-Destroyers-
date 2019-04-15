using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enumerations;
using System;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;

        //Faction properties
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }

        //HealthPoints properties
        public virtual int HealthPoints
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
        public virtual int Level
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
                if (value.Length >= 3 && value.Length <= 30)
                {
                    this.name = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 30");
            }
        }

        // inplemented Attack Interface
        public abstract void Attack();
        
        public abstract void SpecialAttack();
        

        // inplemented Defend Interface 
        public abstract void Defend();
        

    }
}

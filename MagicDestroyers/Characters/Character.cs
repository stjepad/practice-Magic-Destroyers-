using MagicDestroyers.Characters.Interfaces;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private Weapon weapon;
        private Armor bodyArmor;
        private bool isAlive;
        private int scores;


        public Weapon Weapon
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
        public Armor BodyArmor
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
                if (value >= 0 && value <= 30)
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
        public abstract int Attack();
        
        public abstract int SpecialAttack();
        

        // inplemented Defend Interface 
        public abstract int Defend();

        // Is alive bool
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }

        // scores 
        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }


        //takeDamage
        public void TakeDamage(int damage, string attackerName)
        {
            if (this.Defend() < damage)
            {
            this.healthPoints = this.healthPoints - damage + this.Defend();

                if(this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha your damage was not enough to harm me");
            }

            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name}received {damage}  damage from {attackerName}, and is now dead" );
            }
            else
            {
                Console.WriteLine($"{this.name}received {damage} damage from {attackerName} , and has {this.healthPoints} health points left");
            }
        }

        public void WonBattle()
        {
            this.scores++;
            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}

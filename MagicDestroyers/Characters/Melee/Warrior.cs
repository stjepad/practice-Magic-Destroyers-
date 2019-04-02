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
        
        public int AblilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

        //Constructor
        public Warrior()
        {

        }
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

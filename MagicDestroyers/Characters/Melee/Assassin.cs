using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public int AblilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

        //Constructor
        public Assassin()
        {

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
    }
}

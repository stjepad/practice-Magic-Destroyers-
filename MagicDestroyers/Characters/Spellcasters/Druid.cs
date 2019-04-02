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

        public int AblilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

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

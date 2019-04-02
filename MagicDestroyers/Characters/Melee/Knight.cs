using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Chainlink bodyArmor;
        private Hammer weapon;

        public int AblilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

        //Constructor
        public Knight()
        {

        }
        //Abilities
        public void HolyBlow()
        {
            throw new NotImplementedException();
        }
        public void PurifySoul()
        {
            throw new NotImplementedException();
        }

        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}

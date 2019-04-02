using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcasters
{
   public class Mage
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private ClothRobe bodyArmor;
        private Staff weapon;

        public int AblilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

        //Constructor
        public Mage()
        {

        }
        //Abilities
        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }
        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}

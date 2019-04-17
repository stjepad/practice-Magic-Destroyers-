using MagicDestroyers.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers
{
   public static class Consts
    {
        public static class Warrior
        {
        public const int DEFAULT_ABILITYPOINTS = 7;
        public const Faction DEFAULT_FACTION = Faction.Melee;
        public const int DEFAULT_HEALTHPOINTS = 10;
        public const int DEFAULT_LEVEL = 7;
        public const string DEFAULT_NAME = "Spartan ";
        }

        public static class Mage
        {
        public const int DEFAULT_MANAPOINTS = 15;
        public const Faction DEFAULT_FACTION = Enumerations.Faction.Spellcaster;
        public const int DEFAULT_HEALTHPOINTS = 7;
        public const int DEFAULT_LEVEL = 16;
        public const string DEFAULT_NAME = " Mage ";
        }
        

    }
}

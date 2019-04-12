using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 23;

        public Hammer ()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Hammer(int damage)
        {
            this.Damage = damage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private const int DEFAULT_DAMAGE_POINTS = 13;

        public Staff()
            : this(DEFAULT_DAMAGE_POINTS)
            {

            }
        public Staff(int damage)
        {
            this.DamagePoints = damage;
        }

    }
}

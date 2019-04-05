using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor Points value should be a positive number");
                }
            }
        }

        public Staff ()
        {

        }

        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}

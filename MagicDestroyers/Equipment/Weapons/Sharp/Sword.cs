﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_DAMAGE_POINTS = 20;

        public Sword()
            : this(DEFAULT_DAMAGE_POINTS)
        {

        }

        public Sword(int damage)
        {
            this.DamagePoints = damage;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherVest : Leather
    {
        private const int DEFAULT_ARMOR_POINTS = 13;

        public LightLeatherVest()
              : this(DEFAULT_ARMOR_POINTS)
        { }

        public LightLeatherVest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }
    }
}

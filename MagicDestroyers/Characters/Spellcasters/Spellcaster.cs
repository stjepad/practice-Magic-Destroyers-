using System;


namespace MagicDestroyers.Characters.Spellcasters
{
    public class Spellcaster : Character
    {
        private int manaPoints;

        public virtual int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.manaPoints = value;
                }
                else throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
            }
        }
    }
}

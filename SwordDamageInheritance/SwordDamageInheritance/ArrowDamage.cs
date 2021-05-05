using System;
using System.Collections.Generic;
using System.Text;

namespace SwordDamageInheritance
{
    class ArrowDamage
    {
        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 2.5M;

        /// <summary>
        /// Contains the calculate Damage
        /// </summary>
        public int Damage { get; private set; }

        private int roll;

        /// <summary>
        /// Sets or Gets the 3d6 roll.
        /// </summary>
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        private bool magic;

        /// <summary>
        /// True if the sword is magic, false otherwise.
        /// </summary>
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        private bool flaming;

        /// <summary>
        /// True if the sword is flaming, false otherwise.
        /// </summary>
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// Calculates the damage based on the current properties
        /// </summary>

        private void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (magic) baseDamage *= MAGIC_MULTIPLIER;
            if (flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="startingroll">Starting 3d6 roll</param>
        public ArrowDamage(int startingroll)
        {
            roll = startingroll;
            CalculateDamage();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Characters
{
    class Rouge : Hero
    {
        public Rouge()
        {
            Strength = 2;
            Dexterity = 6;
            Intelligence = 1;
            PrimaryAttribute = "Dexterity";

            // Level up stats
            StrengthLevlUp = 1;
            DexterityLevelUp = 4;
            IntelligenceLevelUp = 1;

            // Allows weapons
            weaponAllow.Add(2);
            weaponAllow.Add(5);

            // Armor allow
            armorAllow.Add(1);
            armorAllow.Add(2);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Characters
{
    class Ranger : Hero
    {
        public Ranger()
        {
            Strength = 1;
            Dexterity = 7;
            Intelligence = 1;
            PrimaryAttribute = "Dexterity";

            // Level up stats
            StrengthLevlUp = 1;
            DexterityLevelUp = 5;
            IntelligenceLevelUp = 1;

            // Weapons allow
            weaponAllow.Add(1);

            // Armor allow
            armorAllow.Add(1);
            armorAllow.Add(2);
        }
    }
}

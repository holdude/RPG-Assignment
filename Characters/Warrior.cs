using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Characters
{
    class Warrior : Hero
    {
        public Warrior()
        {
            Strength = 5;
            Dexterity = 2;
            Intelligence = 1;
            PrimaryAttribute = "Strength";

            // Sets level up stats
            StrengthLevlUp = 3;
            DexterityLevelUp = 2;
            IntelligenceLevelUp = 1;

            // Allows weapons
            weaponAllow.Add(0);
            weaponAllow.Add(3);
            weaponAllow.Add(5);

            // Armor allow
            armorAllow.Add(2);
            armorAllow.Add(3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Characters
{
   public class Mage : Hero{


        // On mage create set lv and attributes
        public Mage()
        {
            
            Strength = 1;
            Dexterity = 1;
            Intelligence = 8;
            PrimaryAttribute = "Intelligence";

            // Sets level up stats
            StrengthLevlUp = 1;
            DexterityLevelUp = 1;
            IntelligenceLevelUp = 5;

            // Allows weapons

            weaponAllow.Add(4);
            weaponAllow.Add(6);

            // Allows armos
            armorAllow.Add(0);
        }



    }
}

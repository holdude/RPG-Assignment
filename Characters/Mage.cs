using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Characters
{
    class Mage : Hero{


        // On mage create set lv and attributes
        public Mage()
        {
            Level = 1;
            Strength = 1;
            Dexterity = 1;
            Intelligence = 8;
            PrimaryAttribute = "Intelligence";


        }

        // On level up mage
        public void levelUp()
        {
            Strength += 1;
            Dexterity += 1;
            Intelligence += 5;
        }

    }
}

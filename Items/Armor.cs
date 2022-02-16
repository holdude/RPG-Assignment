using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Items
{
    class Armor : Item
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public int armorType {get; set;}


        // Armor list
        List<String> armorTypes = new List<string>()
        {
            "Cloth",
            "Leather",
            "Mail",
            "Plate"
        };

        public Armor(int strength, int dexterity, int intelligence)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        // get the name based on type
        public string getArmortypeName()
        {
            return armorTypes[armorType];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Items
{
    public class Armor : Item
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

        // Returns name based on what type(int) it has
        public string getArmortypeName()
        {
            return armorTypes[armorType];
        }
    }
}

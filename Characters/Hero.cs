using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Characters
{
    abstract class Hero{

        public string Name { get; set; }
        public string PrimaryAttribute { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Damage { get; set; }



        public void displayStats()
        {
           Console.WriteLine($"The Lv { Level} hero {Name} has these current stats: Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}, Primary Attribute: {PrimaryAttribute}");
        }

        private void calculateDamage()
        {
            // Spread out while working

        }
    }
}

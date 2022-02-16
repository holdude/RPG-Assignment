using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Items
{
 public abstract class Item
    {
        public string Name { get; set; }
        public int levelReq { get; set; }




        // Slot 0 = weapon Slot 1 = armor slot
        public int Slot { get; set; }

        // 0 = Weapon, 1 = Armor
        public int Type { get; set; }
    
    }


}

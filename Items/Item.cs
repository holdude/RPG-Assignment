using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Items
{
    abstract class Item
    {
        public string Name { get; set; }
        public int levelReq { get; set; }
        public string Slot { get; set; }
    
    }


}

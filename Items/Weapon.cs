using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Items
{
    class Weapon : Item
    {
        public int Damage {get; set;}
        public int DPS { get; set; }
        public int AttackSpeed { get; set; }

        public int weaponType { get; set; }

        List<String> weaponTypes = new List<string>()
        {
           "Axe",
           "Bow",
           "Dagger",
           "Hammer",
           "Staff",
           "Sword",
           "Wand"
        };

        public Weapon(int damage, int aSpeed)
        {
            Damage = damage;
            AttackSpeed = aSpeed;

            Type = 0;
            Slot = 0;
            // Sets name from input

            DPS = Damage * AttackSpeed;

    

            

        }

        // get the name based on type
        public string getWeapontypeName()
        {
            return weaponTypes[weaponType];
        }

        public void toString()
        {
            Console.WriteLine($"Name: {Name} Damage: {Damage} DPS: {DPS} LevelReq: {levelReq}");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Items
{
   public class Weapon : Item
    {
        public double Damage {get; set;}
        public double DPS { get; set; }
        public double AttackSpeed { get; set; }

        public int weaponType { get; set; }


        // List of weapon types
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

        public Weapon(double damage, double aSpeed)
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


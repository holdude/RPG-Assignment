using RPG_Assignment.Items;
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


        public int IntelligenceLevelUp { get; set; }
        public int StrengthLevlUp { get; set; }
        public int DexterityLevelUp { get; set; }

        // List for weapon types available for class
        public List<int> weaponAllow = new List<int>();
        public List<int> armorAllow = new List<int>();


        // Weapon
        public Weapon weapon { get; set; }
        // Weapon id
        /// <summary>
        /// Axe = 0
        /// Bow = 1
        /// Dagger = 2
        /// Hammer = 3
        /// Staff = 4
        /// Sword = 5
        /// Wand = 6
        /// </summary>

        // Armor
        public IDictionary<string, Armor> slots = new Dictionary<string, Armor>();

        /// Cloth = 0
        /// Leather = 1
        /// Mail = 2
        /// Plate = 3


        public Hero()
        {
            slots.Add("Head", null);
            slots.Add("Body", null);
            slots.Add("Legs", null);
        }



        public void displayStats()
        {
           Console.WriteLine($"The Lv { Level} hero {Name} has these current stats: Strength: {Strength}, Dexterity: {Dexterity}, Intelligence: {Intelligence}, Primary Attribute: {PrimaryAttribute}");
            if(weapon != null)
            {
                Console.WriteLine($"Currently handling: {weapon.Name}");
            }

            Console.WriteLine("------------------Armor------------------");

            foreach(string arm in slots.Keys)
            {
                if (slots[arm] != null)
                {
                    Console.WriteLine($"{arm}: {slots[arm].Name}");
                } else
                {
                    Console.WriteLine($"{arm}: ");
                }
                
                
            }  
            

        }

        private void calculateDamage()
        {
            // Spread out while working
            // Run when new item or level up

            // Base attributes sum
            int attSum = Strength + Intelligence + Dexterity;
            // Armor sum
            int armorSum = 0;

            foreach(string arm in slots.Keys)
            {
                if(slots[arm] != null)
                {
                    armorSum +=slots[arm].Dexterity;
                    armorSum += slots[arm].Strength;
                    armorSum += slots[arm].Intelligence;
                }
            }

            // Total attributes
            int totAtt = attSum+armorSum;

            // Weapon damage
            if(weapon != null)
            {
                weapon.DPS * (1 + PrimaryAttribute / 100);

            } else
            {
                Damage = 0;
            }

        }

        public Boolean equipWeapon(Weapon weaponet)
        {
            Boolean allow = false;
  
            try
            {
                // Check if hero lv is high enough
                if (weaponet.levelReq <= Level)
                {
                    // Check if weapon can be used by class
                    foreach (int weap in weaponAllow)
                    {
                        if (weaponet.weaponType.Equals(weap))
                        {
                            allow = true;
                        };
                    }

                    if(allow == false)
                    {
                        throw new Exception($"{this.getObjName()} class can't use the weapon type {weaponet.getWeapontypeName()}");

                    } else
                    {

                        weapon = weaponet;

                        Console.WriteLine($"{weapon.Name} equiped");

                        return true;

                    }


                }

                else
                {
                    throw new Exception($"{ Name } is only level { Level}, the required level for this weapon is { weaponet.levelReq }");

                }

            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        // add armor
        public Boolean addArmor(Armor armo, string placement)
        {
            Boolean allow = false;

            try
            {
                // Check hero level req
                if(armo.levelReq <= Level)
                {
                    // can armor be used by class
                    armorAllow.ForEach(arm =>
                    {
                        if (armo.armorType.Equals(arm)){
                            allow = true;
                        }

                    });

                    if(allow == false)
                    {
                        throw new Exception($"{this.getObjName()} class can't use {armo.getArmortypeName()} type");
                    }
                    else
                    {
                        // Added
                        Console.WriteLine("Armor added");
                        slots[placement] = armo;
                        return true;
                    }
                } else
                {
                    throw new Exception($"{Name} is only level {Level}, the required level for this armor is {armo.levelReq}");
                }




            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }







        // returns the name of the object (Mage, Rouge etc)
        public string getObjName()
        {
            return this.GetType().Name;
        }


        // On level up 
        public void levelUp()
        {
            int lvlOld = Level;
            int strOld = Strength;
            int dexOld = Dexterity;
            int intOld = Intelligence;

            Level += 1;
            Strength += StrengthLevlUp;
            Dexterity += DexterityLevelUp;
            Intelligence += IntelligenceLevelUp;


            // LEVEL UP CONSOLE
            Console.WriteLine("??????????????????????????????????????????????");
            Console.WriteLine("                   LEVEL UP                 ");
            Console.WriteLine("                                            ");
            Console.WriteLine($"           Level:       {lvlOld} => {Level}          ");
            Console.WriteLine($"           Inteligence: {intOld} => {Intelligence}   ");
            Console.WriteLine($"           Strength:    {strOld} => {Strength}       ");
            Console.WriteLine($"           Dexterity:   {dexOld} => {Dexterity}      ");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");
            Console.WriteLine("                                            ");
            Console.WriteLine("??????????????????????????????????????????????");

        }
    }


}

using RPG_Assignment.Exceptions;
using RPG_Assignment.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment.Characters
{
    public abstract class Hero{

        public string Name { get; set; }
        public string PrimaryAttribute { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public double Damage { get; set; }


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
            Level = 1;
            Damage = 1;
            slots.Add("Head", null);
            slots.Add("Body", null);
            slots.Add("Legs", null);
        }


        /// <summary>
        /// Displays the current stats of the hero, based on their level and gear
        /// </summary>
        public void displayStats()
        {
           calculateDamage();
           Console.WriteLine();
           Console.WriteLine($"The Lv { Level} hero {Name} has these current stats: \n");
           Console.WriteLine("------------------Stats------------------");
           Console.WriteLine($"Strength:     {Strength} \nDexterity:    {Dexterity} \nIntelligence: {Intelligence} \nDamage:       {Damage}\nPrimary Attribute: {PrimaryAttribute}\n");

           // Checks if there is a weapon equiped
            if (weapon != null)
            {
                Console.WriteLine($"Currently handling: {weapon.Name}");
            }

            Console.WriteLine("------------------Armor------------------");

            // Checks if armor is equiped or null
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
        /// <summary>
        /// Calculates the damage the hero can do, based on level and gear
        /// </summary>
        private void calculateDamage()
        {

            double damageOut = 1;
            // Check if weapon equiped

            if(weapon != null)
            {

                damageOut = weapon.DPS * (1 + (getPrimaryAtt() / 100));

            } else
            {
                damageOut = 1;
            }

            Damage = damageOut;
        }

        /// <summary>
        /// Tries to equip the chosen weapon
        /// Throws InvalidWeaponClass if not allowed
        /// </summary>
        /// <param name="weaponet"></param>
        /// <returns></returns>
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

                    // Can't be used by this class
                    if(allow == false)
                    {
                        Console.WriteLine($"{this.getObjName()} class can't use the weapon type {weaponet.getWeapontypeName()}");

                        throw new InvalidWeaponClass();

                    } else
                    {
                        // Equiped
                        weapon = weaponet;

                        Console.WriteLine($"{weapon.Name} equiped");
                        calculateDamage();

                        return true;

                    }


                }

                else
                {
                    // To low level
                    Console.WriteLine($"{ Name } is only level { Level}, the required level for this weapon is { weaponet.levelReq }");
                    throw new InvalidWeaponClass();
                }


            } catch (Exception e)
            {

                return false;
             
            }

        }

        /// <summary>
        /// Tries to add armor to hero, takes in armor piece and postion
        /// Throws InvalidArmor if error
        /// </summary>
        /// <param name="armo"></param>
        /// <param name="placement"></param>
        /// <returns></returns>
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
                        throw new InvalidArmor($"{this.getObjName()} class can't use {armo.getArmortypeName()} type");
                    }
                    else
                    {
                        // Added
                        Console.WriteLine("Armor added");
                        // Check if armor currently present and remove their stats
                        if(slots[placement] != null)
                        {
                            // Exists
                            // Take away stats from hero
                            Intelligence -= slots[placement].Intelligence;
                            Strength -= slots[placement].Strength;
                            Dexterity -= slots[placement].Dexterity;

                        }

                        // Adds to slot
                        slots[placement] = armo;

                        // ADD THE STATS
                        Intelligence += slots[placement].Intelligence;
                        Strength += slots[placement].Strength;
                        Dexterity += slots[placement].Dexterity;

                       


                        return true;
                    }
                } else
                {
                    throw new InvalidArmor($"{Name} is only level {Level}, the required level for this armor is {armo.levelReq}");
                }




            } catch (Exception e)
            {
                return false;
            }

        }

        /// <summary>
        /// Checks for what the primary attribute is based on hero and returns it
        /// </summary>
        /// <returns></returns>
        public double getPrimaryAtt()
        {
            switch (PrimaryAttribute)
            {
                case "Intelligence":
                    return Intelligence;

                case "Strength":
                    return Strength;

                case "Dexterity":
                    return Dexterity;
            }
            return 0;
        }




        // returns the name of the object (Mage, Rouge etc)
        public string getObjName()
        {
            return this.GetType().Name;
        }


        /// <summary>
        /// Levels up the hero based on the role
        /// </summary>
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

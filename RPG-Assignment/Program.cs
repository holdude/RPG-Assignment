using RPG_Assignment.Characters;
using RPG_Assignment.Items;
using System;
using System.Collections.Generic;

namespace RPG_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Active hero
            List<Hero> heroes = new List<Hero>();
            // index of selected hero
            int selectedHero = 0;


            // Create weapons
            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon(3,2) {Name ="Vindication", weaponType=0, levelReq=1},
                new Weapon(4,5) {Name ="Cometfall", weaponType=1, levelReq=2},
                new Weapon(2,4) {Name ="Netherbane", weaponType=2, levelReq=3},
                new Weapon(6,1) {Name ="Draughtbane", weaponType=3, levelReq=4},
                new Weapon(3,3) {Name ="Lifebender", weaponType=4, levelReq=5},
                new Weapon(4,4) {Name ="Starlight", weaponType=5, levelReq=6},
                new Weapon(1,5) {Name ="Glimmer", weaponType=6, levelReq=7},
                new Weapon(7, 1.1) { Name = "Axe", weaponType = 0, levelReq = 1 }

        };

            // Create armor
            List<Armor> armors = new List<Armor>()
            {
                new Armor(1,1,1) {Name ="Cloth", armorType=0, levelReq=1},
                new Armor(2,1,3) {Name ="Leather", armorType=1, levelReq=2},
                new Armor(2,3,1) {Name ="Mail", armorType=2, levelReq=3},
                new Armor(2,1,5) {Name ="Plate", armorType=3, levelReq=4},
                new Armor(1, 1, 5) { Name = "Plate2", armorType = 3, levelReq = 1 }
        };



            Mage newMage = new Mage() { Name = "Desperado" };
            heroes.Add(newMage);


            mainMenu();



            /// Menu for creaing hero
             void createHero()
            {
                // Name
                Console.WriteLine("Create a character");
                Console.WriteLine("Hero name: ");
                string heroName = Console.ReadLine();

                // Class
                Console.WriteLine();
                Console.WriteLine("Select class: ");
                Console.WriteLine("1 - Mage \n2 - Ranger \n3 - Rouge \n4 - Warrior");

                int heroClass = Convert.ToInt32(Console.ReadLine());

                // Check for
                if(heroClass == 1)
                {
                    // Mage
                    heroes.Add(new Mage() { Name = heroName });
                    selectedHero = heroes.Count - 1;

                    heroMenu();

                } else if(heroClass == 2)
                {
                    // Ranger
                    heroes.Add(new Ranger() { Name = heroName });
                    selectedHero = heroes.Count - 1;
                    heroMenu();


                } else if (heroClass == 3)
                {
                    // Rouge
                    heroes.Add(new Rouge() { Name = heroName });
                    selectedHero = heroes.Count - 1;
                    heroMenu();
                } else if(heroClass == 4)
                {
                    // Warrior
                    heroes.Add(new Warrior() { Name = heroName });
                    selectedHero = heroes.Count - 1;
                    heroMenu();
                } else
                {
                    // Error
                    Console.WriteLine("Invalid input");
                    mainMenu();
                }


            }


            // Main hub
            void mainMenu()
            {
                /// Create new hero
                /// Create item ( Weapon/Armor)
                /// Select hero
                Console.WriteLine("MAIN MENU \n1 - Create new hero \n2 - Create new item \n3 - Select hero");
                int mainMenuChoice = Convert.ToInt32(Console.ReadLine());

                if (mainMenuChoice == 1)
                {
                    createHero();
                } else if (mainMenuChoice == 2)
                {
                    // new item
                    Console.WriteLine("Function not added");
                    mainMenu();
                } else if (mainMenuChoice == 3)
                {
                    // Select hero
                    // Print out all heroes

                    // Check if there are any

                    if(heroes.Count == 0)
                    {
                        // No heroes
                        Console.WriteLine("No heroes available, create one!");
                        createHero();
                    } else
                    {
                        int counter = 0;

                        heroes.ForEach(heroen =>
                       {
                           Console.WriteLine($"{counter} - {heroen.Name} the lv {heroen.Level} {heroen.getObjName()}");
                           counter++;
                       });

                        // Input
                        Console.WriteLine("Select hero: ");
                        int heroSel = Convert.ToInt32(Console.ReadLine());

                        if(heroSel > counter)
                        {
                            Console.WriteLine("Invalid hero selected");
                            createHero();
                        }

                        selectedHero = heroSel;
                        Console.WriteLine($"Hero {heroes[selectedHero].Name} selected");
                        heroMenu();
                    }
                }
            }


            // Hero menu
            void heroMenu()
            {
                /// Back to main menu
                /// Level up
                /// Equip weapon
                /// Equip armor
                /// Show inventory
                /// Show Damage
                ///
                Console.WriteLine();
                Console.WriteLine("Character menu");
                Console.WriteLine("0 - Back to main menu \n1 - Level up \n2 - Equip weapon \n3 - Equip armor \n4 - Show inventory");
                int heroMenuChoice = Convert.ToInt32(Console.ReadLine());

                if (heroMenuChoice == 0)
                {
                    // back to menu
                    mainMenu();
                } else if (heroMenuChoice == 1)
                {
                    // Level up
                    heroes[selectedHero].levelUp();
                    heroMenu();

                } else if (heroMenuChoice == 2)
                {
                    // Equip weapon
                    equipWeapon();
                
                } else if (heroMenuChoice == 3)
                {
                    // Equip armor
                    equipArmor();

                } else if (heroMenuChoice == 4)
                {
                    // Show inventory
                    heroes[selectedHero].displayStats();
                    heroMenu();
                } else
                {
                    // Wrong input
                    Console.WriteLine("Invald input");
                    heroMenu();
                }
            }

            // Equiping armor
            void equipArmor()
            {
                Console.WriteLine();
                // Print out all armor
                int counter = 0;
                armors.ForEach(arm =>
                {
                    Console.WriteLine($"{counter} - The {arm.getArmortypeName()} {arm.Name}. Strength: {arm.Strength}, Dexterity: {arm.Dexterity}, Intelligence: {arm.Dexterity}");
                    counter++;

                });

                

                Console.WriteLine("Select armor");
                Console.WriteLine("99 - Back");

                int armorChoice = Convert.ToInt32(Console.ReadLine());

                if(armorChoice == 99)
                {
                    // Return
                    heroMenu();
                } else if (armorChoice < counter)
                {
                    // Check where to equip
                    Console.WriteLine($"Where to equip {armors[armorChoice].Name}?");

                    Console.WriteLine("0 - Head \n1 - Body \n2 - Legs");
                    int placeChoice = Convert.ToInt32(Console.ReadLine());

                    Boolean addedArm = false;

                    if (placeChoice == 0)
                    {
                        // HEAD

                         addedArm = heroes[selectedHero].addArmor(armors[armorChoice], "Head");



                    } else if(placeChoice == 1)
                    {
                        // Body
                        addedArm = heroes[selectedHero].addArmor(armors[armorChoice], "Body");
                    } else if(placeChoice ==2) {
                        // LEGS
                        addedArm = heroes[selectedHero].addArmor(armors[armorChoice], "Legs");
                    } else
                    {
                        // Invalid
                        Console.WriteLine("Invalid input");
                        heroMenu();
                    }

                    heroMenu();

                }
                {

                }
            }

            // Equip weapon
            void equipWeapon()
            {
                Console.WriteLine();
                /// Print out all weapons
                /// 
                int counter = 0;

                weapons.ForEach(weap =>
                {
                    Console.WriteLine($"{counter} - The {weap.getWeapontypeName()} {weap.Name}. Damage: {weap.Damage} Attack speed: {weap.AttackSpeed}");
                    counter++;
                });

                // Input
                Console.WriteLine("99 - Back");
                Console.WriteLine("Select weapon:");

                int equipChoice = Convert.ToInt32(Console.ReadLine());

                // Checks
                if(equipChoice == 99)
                {
                    // Return
                    heroMenu();
                } else if(equipChoice < counter)
                {
                    // Try to equip weapon
                    Boolean equipedBoolean = heroes[selectedHero].equipWeapon(weapons[equipChoice]);

                    heroMenu();

                } else
                {
                    Console.WriteLine("Invalid input");
                    equipWeapon();
                }
            }


        }

    }
}

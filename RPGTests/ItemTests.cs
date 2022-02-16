using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RPG_Assignment.Exceptions;
using RPG_Assignment.Characters;
using RPG_Assignment.Items;

namespace RPGTests
{
    public class ItemTests
    {
        
        [Fact]
        public void Weapon_EquipToHighLevel_Should_Throw_InvalidHeroClassEror()
        {
            // Arrange
            Warrior warrior = new Warrior() { Name = "Hero" };
            Weapon weapon = new Weapon(3, 2) { Name = "Axe", weaponType = 0, levelReq = 2 };



            //Asses
            Assert.Throws<InvalidWeaponClass>(() => warrior.equipWeapon(weapon));



        }


        [Fact]
        public void Armor_EquipHighLevel_Should_Throw_Exception()
        {
            // Arrange
            Warrior warrior = new Warrior() { Name = "Hero" };
            Armor armor = new Armor(2, 1, 5) { Name = "Plate", armorType = 3, levelReq = 2 };

            // Asses
            Assert.Throws<InvalidArmor>(() => warrior.addArmor(armor, "Head"));
        }
        

        [Fact]
        public void Weapon_EquipWrongType_Should_Throw_Exception()
        {
            // Arrange
            Warrior warrior = new Warrior() { Name = "Hero" };
            Weapon weapon = new Weapon(4, 5) { Name = "Cometfall", weaponType = 1, levelReq = 1 };


            // Asses
            Assert.Throws<InvalidWeaponClass>(() => warrior.equipWeapon(weapon));

        }

        [Fact]
        public void Armor_EquipWrongArmorType_Should_Throw_Exception()
        {
            // Arrange
            Warrior warrior = new Warrior() { Name = "Hero" };
            Armor armor = new Armor(2, 1, 5) { Name = "Cloth", armorType = 0, levelReq = 1 };

            // Asses
            Assert.Throws<InvalidArmor>(() => warrior.addArmor(armor, "Head"));
        }

        [Fact]
        public void Weapon_EquipCorrectWeapon_Should_Throw_True()
        {
            // Arrange
            Boolean expected = true;
            Warrior warrior = new Warrior() { Name = "Hero" };
            Weapon weapon = new Weapon(3, 2) { Name = "Axe", weaponType = 0, levelReq = 1 };

            // Act
            Boolean actual = warrior.equipWeapon(weapon);

            // Asses
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Armor_EquipCorrectWeapon_Should_Throw_True()
        {
            // Arrange
            Boolean expected = true;
            Warrior warrior = new Warrior() { Name = "Hero" };
            Armor armor = new Armor(2, 1, 5) { Name = "Plate", armorType = 3, levelReq = 1 };

            // Act
            Boolean actual = warrior.addArmor(armor,"Head");

            // Asses
            Assert.Equal(expected, actual);

        }
        
        [Fact]
        public void Damage_NoWeaponEquiped_ShouldDo_1_Damage()
        {
            // Arrange
            int expected = 1;
            Warrior warrior = new Warrior() { Name = "Hero" };

            // Act
            Double actual = warrior.Damage;

            // Asses
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Damage_WeaponEquiped_ShouldDoDmg()
        {
            // Arrange
            double expected = 8.085;
            Warrior warrior = new Warrior() { Name = "Hero" };
            Weapon weapon = new Weapon(7, 1.1) { Name = "Axe", weaponType = 0, levelReq = 1 };

            // act
            warrior.equipWeapon(weapon);
            double actual = warrior.Damage;

            // Asses
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Damage_Weapon_And_Armo_Equiped_Shoud_Do_Dmg()
        {
            // Arrange
            double expect = 8.162;
            Warrior warrior = new Warrior() { Name = "Hero" };
           
            Armor armor = new Armor(1, 1, 5) { Name = "Plate", armorType = 3, levelReq = 1 };
            Weapon weapon = new Weapon(7, 1.1) { Name = "Axe", weaponType = 0, levelReq = 1 };
            
            warrior.addArmor(armor, "Body");
            warrior.equipWeapon(weapon);
            // Act

            double actual = warrior.Damage;

            // Asses
            Assert.Equal(expect, actual);
        }
    }
}

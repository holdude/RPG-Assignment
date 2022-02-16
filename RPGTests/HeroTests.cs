using System;
using Xunit;
using RPG_Assignment.Characters;

namespace RPGTests
{
    public class HeroTests
    {
        [Fact]
        public void Hero_LevelCreated_ShouldShowLevel1_OnCreate()
        {
            // Arrange
            int expected = 1;
            Mage mage = new Mage() { Name = "HeroMage" };

            // Act

            int actual = mage.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Hero_LevelUp_ShouldBeLevel2_OnLevelUp()
        {
            // Arrange
            int expected = 2;
            Mage mage = new Mage() { Name="HeroMage"};

            // Act
            mage.levelUp();
            int actual = mage.Level;

            // Assert
            Assert.Equal(expected, actual);
        }

        // Hero classes

        [Fact]
        public void Mage_Default_Attributes_OnCreate()
        {
            // Arrange
            int expectedStr = 1;
            int expectedDex = 1;
            int exptectedInt = 8;
            string expectedPrimary = "Intelligence";
            
            Mage hero = new Mage() { Name = "hero" };

            // Act
            int actuallStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;
            string actualPri = hero.PrimaryAttribute;

            
            // Assert
            Assert.Equal(expectedStr, actuallStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(exptectedInt, actualInt);
            Assert.Equal(expectedPrimary, actualPri);

        }

        [Fact]
        public void Ranger_Default_Attributes_OnCreate()
        {
            // Arrange
            int expectedStr = 1;
            int expectedDex = 7;
            int exptectedInt = 1;
            string expectedPrimary = "Dexterity";

            Ranger hero = new Ranger() { Name = "Hero" };

            // Act
            int actuallStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;
            string actualPri = hero.PrimaryAttribute;


            // Assert
            Assert.Equal(expectedStr, actuallStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(exptectedInt, actualInt);
            Assert.Equal(expectedPrimary, actualPri);

        }

        [Fact]
        public void Rouge_Default_Attributes_OnCreate()
        {
            // Arrange
            int expectedStr = 2;
            int expectedDex = 6;
            int expectedInt = 1;
            string expectedPrimary = "Dexterity";

            Rouge hero = new Rouge() { Name = "Hero" };

            // Act
            int actuallStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;
            string actualPri = hero.PrimaryAttribute;


            // Assert
            Assert.Equal(expectedStr, actuallStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(expectedInt, actualInt);
            Assert.Equal(expectedPrimary, actualPri);

        }

        [Fact]
        public void Warrior_Default_Attributes_OnCreate()
        {
            // Arrange
            int expectedStr = 5;
            int expectedDex = 2;
            int exptectedInt = 1;
            string expectedPrimary = "Strength";

            Warrior hero = new Warrior() { Name = "Hero" };

            // Act
            int actuallStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;
            string actualPri = hero.PrimaryAttribute;


            // Assert
            Assert.Equal(expectedStr, actuallStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(exptectedInt, actualInt);
            Assert.Equal(expectedPrimary, actualPri);

        }
    
        [Fact]
        public void Mage_LevelUp_Attributes_OnLevelUp()
        {
            // Arrange
            int expectedStr = 2;
            int expectedDex = 2;
            int expectedInt = 13;

            Mage hero = new Mage() { Name = "Hero" };

            // Act
            hero.levelUp();
            int actualStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;

            // Assert
            Assert.Equal(expectedStr, actualStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(expectedInt, actualInt);
        }

        [Fact]
        public void Ranger_LevelUp_Attributes_OnLevelUp()
        {
            // Arrange
            int expectedStr = 2;
            int expectedDex = 12;
            int expectedInt = 2;

            Ranger hero = new Ranger() { Name = "Hero" };

            // Act
            hero.levelUp();
            int actualStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;

            // Assert
            Assert.Equal(expectedStr, actualStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(expectedInt, actualInt);
        }

        [Fact]
        public void Rouge_LevelUp_Attributes_OnLevelUp()
        {
            // Arrange
            int expectedStr = 3;
            int expectedDex = 10;
            int expectedInt = 2;

            Rouge hero = new Rouge() { Name = "Hero" };

            // Act
            hero.levelUp();
            int actualStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;

            // Assert
            Assert.Equal(expectedStr, actualStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(expectedInt, actualInt);
        }

        [Fact]
        public void Warrior_LevelUp_Attributes_OnLevelUp()
        {
            // Arrange
            int expectedStr = 8;
            int expectedDex = 4;
            int expectedInt = 2;

            Warrior hero = new Warrior() { Name = "Hero" };

            // Act
            hero.levelUp();
            int actualStr = hero.Strength;
            int actualDex = hero.Dexterity;
            int actualInt = hero.Intelligence;

            // Assert
            Assert.Equal(expectedStr, actualStr);
            Assert.Equal(expectedDex, actualDex);
            Assert.Equal(expectedInt, actualInt);
        }
    }

}

using RPG_Assignment.Characters;
using System;

namespace RPG_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mage newMage = new Mage() { Name = "Desperado" };


            newMage.displayStats();
            newMage.levelUp();
            newMage.displayStats();
        }
    }
}

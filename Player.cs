using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AdventureGameR5
{
    [Serializable]
    public class Player
    {
        Random rand = new Random();

        public string name;
        public int id;
        public int coins = 5000000;
        public int Level = 10;
        public int xp = 0;
        public int health = 30;
        public int damage = 10;
        public int armorValue = 0;
        public int potion = 5;
        public int weaponValue = 10;

        public int mods = 0;

        public enum PlayerClass { Power, Hope, Lost };
        public PlayerClass currentClass = PlayerClass.Hope;
        public int GetHealth()
        {
            int upper = (2 * mods + 5);
            int lower = (mods + 2);
            return rand.Next(lower, upper);
        }
        public int GetPower()
        {
            int upper = (2 * mods + 2);
            int lower = (mods + 1);
            return rand.Next(lower, upper);
        }
        public int GetCoins()
        {
            int upper = (10 * mods + 50);
            int lower = (10 * mods + 10);
            return rand.Next(lower, upper);
        }
        public int GetXP()
        {
            int upper = (20 * mods + 50);
            int lower = (15 * mods + 10);
            return rand.Next(lower, upper);
        }
        public int GetLevelUpValue()
        {
            return 100 * Level + 400;

        }

        public bool CanLevelUp()
        {
            if (xp >= GetLevelUpValue())
            return true;
            else
                return false;
        }
        public void LevelUp()
        {
            while (CanLevelUp())
            {
                xp -= GetLevelUpValue();
                Level++;
            }
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine ("Congrats your spirit is grow to another level" + Level + "!");
            Console.ResetColor();
        }
    }
}

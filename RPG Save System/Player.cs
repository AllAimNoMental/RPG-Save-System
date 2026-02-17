using System;
using System.Collections.Generic;
using System.Text;
using Savable;

namespace Player
{
    public class Players: ISaveable, IGameCharacter
    {
        private string Name;
        private int Health;
        private int Level;

        public Players(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public void LevelUp()
        {
           
        }
        public void AddItem(Item item)
        {

        }
        public void TakeDamage(int amount)
        {
            Health -= amount;   
            if (Health < 0)
            {
                Health = 0;
            }
           
        }
        string ToJson()
        {

        }
    }
}

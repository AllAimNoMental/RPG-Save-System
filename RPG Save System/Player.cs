using System;
using System.Collections.Generic;
using System.Text;
using Savable;
using Item;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace Player
{
    public class Players: ISaveable, IGameCharacter
    {
        public string Name;
        public int Health;
        public int Level;
        public List<Items> inventory;
        public Players(string name)
        {
            Name = name;
            Health = 10;
            Level = 1;
            inventory = new List<Items>();
        }

        public void LevelUp()
        {
            Level += 1;
        }
        public void AddItem(Items item)
        {
            inventory.Add(item);
        }
        public void TakeDamage(int amount)
        {
            Health -= amount;   
            if (Health < 0)
            {
                Health = 0;
            }
           
        }
       public  string ToJson()
        {
            string Json = JsonSerializer.Serialize(this);
            return Json;
        }
    }
}

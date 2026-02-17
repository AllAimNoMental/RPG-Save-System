using System;
using System.Collections.Generic;
using System.Text;

namespace Savable
{
    public interface ISaveable
    {
        public string ToJson();
    }
    public interface IGameCharacter
    {
        public void TakeDamage(int amount);
        public void LevelUp();
    }
}

using System;
namespace Characters.Domain.Aggregates
{
    public class Monster
        : Character
    {
        public Monster(string name, int life)
            : base(name, life)
        {
        }
    }
}

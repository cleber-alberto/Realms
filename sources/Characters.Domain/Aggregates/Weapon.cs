using System;
namespace Characters.Domain.Aggregates
{
    public class Weapon
    {
        public string Name { get; private set; }

        public Weapon(string name)
        {
            this.Name = name;
        }
    }
}

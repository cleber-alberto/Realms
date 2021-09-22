using System;

namespace Characters.Domain
{
    public abstract class Character
    {
        public string Name { get; private set; }
        public int Life { get; private set; }

        public Character(string name, int life)
        {
            this.Name = name;
            this.Life = life;
        }

        public void Damage(int amountDamage)
        {
            Life -= amountDamage;
        }

        public void Healing(int amountHealing)
        {
            Life += amountHealing;
        }

    }
}

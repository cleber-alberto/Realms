using System;
namespace Characters.Domain.Aggregates
{
    public class Hero
        : Character
    {
        private const int MAX_LIFE = 100;

        public Hero(string name)
            : base(name, MAX_LIFE)
        {

        }
    }
}

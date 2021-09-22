using System;
namespace Characters.Domain.ValueObjects
{
    public class Dice
    {

        private DiceType _diceType;

        public Dice(DiceType diceType)
        {
            _diceType = diceType;
        }

        public int Roll()
        {
            var random = new Random();
            var result = 0;

            if (_diceType == DiceType.ThreeSides)
            {
                result = random.Next(1, 3);
            }

            if (_diceType == DiceType.SixSides)
            {
                result = random.Next(1, 6);
            }

            if (_diceType == DiceType.TenSides)
            {
                result = random.Next(0, 9);
            }

            if (_diceType == DiceType.TwetySides)
            {
                result = random.Next(1, 20);
            }

            return result;
        }
    }
}

using Characters.Domain.ValueObjects;
using Xunit;
using FluentAssertions;

namespace Characters.Domain.UnitTests.ValueObjects
{
    public class DiceTest
    {
        [Fact]
        public void Dice_Roll_ReturnValuesBetweenOneToThree()
        {
            var dice = new Dice(DiceType.ThreeSides);

            int result = dice.Roll();

            result.Should().BeGreaterThan(0).And.BeLessOrEqualTo(3);
        }


        [Fact]
        public void Dice_Roll_ReturnValuesBetweenOneToSix()
        {
            var dice = new Dice(DiceType.SixSides);

            int result = dice.Roll();

            result.Should().BeGreaterThan(0).And.BeLessOrEqualTo(6);
        }

        [Fact]
        public void Dice_Roll_ReturnValuesBetweenOneToTen()
        {
            var dice = new Dice(DiceType.TenSides);

            int result = dice.Roll();

            result.Should().BeGreaterThan(0).And.BeLessOrEqualTo(9);
        }

        [Fact]
        public void Dice_Roll_ReturnValuesBetweenOneToTwenty()
        {
            var dice = new Dice(DiceType.TwetySides);

            int result = dice.Roll();

            result.Should().BeGreaterThan(1).And.BeLessOrEqualTo(20);
        }
    }
}

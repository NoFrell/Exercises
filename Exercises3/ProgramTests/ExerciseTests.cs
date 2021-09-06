using Exercises;
using FluentAssertions;
using Xunit;

namespace ProgramTests
{
    public class ExerciseTests
    {
        [Theory]
        [InlineData("tacocat", true)]
        [InlineData("madam", true)]
        [InlineData("Wow", true)]
        [InlineData("john", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        public void IsPalindrome(string someString, bool expected)
        {
            Program.IsPalindrome(someString).Should().Be(expected);
        }

        [Theory]
        [InlineData("tacocat is fucking kot", 4)]
        [InlineData("madam is gay", 3)]
        [InlineData("Wow", 1)]
        [InlineData("john", 1)]
        [InlineData("a a", 2)]
        [InlineData("a", 1)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        public void CountWords(string someString, int expected)
        {
            Program.CountWords(someString).Should().Be(expected);
        }

        [Theory]
        [InlineData(96, 4)]
        [InlineData(420, 320)]
        [InlineData(30, 70)]
        [InlineData(-130, 230)]
        [InlineData(99, 1)]
        [InlineData(100, 0)]
        public void HowFarFromOneHundred(int number, int expected)
        {
            Program.HowFarFromOneHundred(number).Should().Be(expected);
        }

        [Theory]
        [InlineData(96, 6)]
        [InlineData(420, 0)]
        [InlineData(30, 0)]
        [InlineData(-131, 1)]
        [InlineData(99, 9)]
        [InlineData(1001, 1)]
        public void GetTheLastDigitOfNumber(int number, int expected)
        {
            Program.GetTheLastDigitOfNumber(number).Should().Be(expected);
        }

        [Theory]
        [InlineData("hitacocat", true)]
        [InlineData("Himadam", true)]
        [InlineData("hIWow", true)]
        [InlineData("HIjohn", true)]
        [InlineData("Hi john", true)]
        [InlineData("hi- hIWow", true)]
        [InlineData("Wow", false)]
        [InlineData("hWow", false)]
        [InlineData("iWow", false)]
        [InlineData("", false)]
        [InlineData(" ", false)]
        [InlineData(null, false)]
        public void StartsWithHi(string input, bool expected)
        {
            Program.StartsWithHi(input).Should().Be(expected);
        }

        [Theory]
        [InlineData(96, 69)]
        [InlineData(42, 24)]
        [InlineData(36, 63)]
        [InlineData(131, 131)]
        [InlineData(92, 29)]
        [InlineData(123, 321)]
        public void ReverseNumber(int input, int expected)
        {
            Program.ReverseNumber(input).Should().Be(expected);
        }

        [Theory]
        [InlineData("beetroot is eee", 5)]
        [InlineData("mommy is elchocholeec", 3)]
        [InlineData("Wow", 0)]
        [InlineData("crusade", 1)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData(null, 0)]
        public void HowManyEsInAString(string input, int expected)
        {
            Program.HowManyEsInAString(input).Should().Be(expected);
        }
    }
}
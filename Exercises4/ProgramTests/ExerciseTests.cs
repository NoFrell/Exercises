using Exercises;
using FluentAssertions;
using Xunit;

namespace ProgramTests
{
    public class ExerciseTests
    {
        [Theory]
        [InlineData("tacocat", "PhpSucks tacocat")]
        [InlineData("vilius", "PhpSucks vilius")]
        [InlineData("", null)]
        [InlineData(" ", null)]
        [InlineData(null, null)]
        public void AddPhpSucks(string input, string expected)
        {
            Program.AddPhpSucks(input).Should().Be(expected);
        }

        [Theory]
        [InlineData(3, "ka", "kakaka")]
        [InlineData(2, "bybis ", "bybis bybis ")]
        [InlineData(4, "ponas jonas", "ponas jonasponas jonasponas jonasponas jonas")]
        [InlineData(0, "", null)]
        [InlineData(0, " ", null)]
        [InlineData(0, null, null)]
        public void RepeatGivenStringTimes(int repeatCount, string input, string expected)
        {
            Program.RepeatGivenStringTimes(repeatCount, input).Should().Be(expected);
        }

        [Theory]
        [InlineData(100, 69, 420, true)]
        [InlineData(13, 1, 10, false)]
        [InlineData(10, 10, 10, true)]
        [InlineData(0, 0, 0, true)]
        public void NumberIsInRange(int number, int from, int to, bool expected)
        {
            Program.NumberIsInRange(number, from, to).Should().Be(expected);
        }

        [Theory]
        [InlineData("[Gays] Vithis", "Gays Vithis")]
        [InlineData("[Lol sudai]", "Lol sudai")]
        [InlineData("Kaka", "Kaka")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        public void RemoveBracesFromString(string input, string expected)
        {
            Program.RemoveBracesFromString(input).Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5}, new[] {5, 2, 3, 4, 1})]
        [InlineData(new[] {1, 2, 5, 3}, new[] {3, 2, 5, 1})]
        [InlineData(new[] {5, 3, 7, 8, 4, 2}, new[] {2, 3, 7, 8, 4, 5})]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, null)]
        public void SwapFirstAndLastElementsOfArray(int[] input, int[] expected)
        {
            if (expected == null)
                Program.SwapFirstAndLastElementsOfArray(input).Should().BeNull();
            else
                Program.SwapFirstAndLastElementsOfArray(input).Should().ContainInOrder(expected);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5}, 2, 1)]
        [InlineData(new[] {1, 2, 1, 3, 1, 1}, 1, 4)]
        [InlineData(new[] {5, 3, 7, 8, 4, 2, 5}, 3, 1)]
        [InlineData(new int[] { }, 9, 0)]
        [InlineData(null, 9, 0)]
        public void HowManyTimesValueInArray(int[] input, int value, int expected)
        {
            Program.HowManyTimesValueInArray(input, value).Should().Be(expected);
        }
    }
}
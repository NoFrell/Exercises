using Exercises;
using FluentAssertions;
using Xunit;

namespace ProgramTests
{
    public class ExerciseTests
    {
        [Fact]
        public void GetNumbersFromOneToTen()
        {
            Program.GetNumbersFromOneToTen().Should().HaveCount(10)
                .And.ContainInOrder(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        [Theory]
        [InlineData("Vilius", "Zobela", "Vilius Zobela")]
        [InlineData("Milda", "Jakstaite", "Milda Jakstaite")]
        [InlineData(null, "Jakstaite", "Jakstaite")]
        [InlineData("Milda", null, "Milda")]
        [InlineData(null, null, null)]
        [InlineData("", null, "")]
        [InlineData(null, "", "")]
        [InlineData("", "", " ")]
        public void GetFullName(string firstName, string lastName, string expected)
        {
            Program.GetFullName(firstName, lastName).Should().Be(expected);
        }

        [Theory]
        [InlineData(2, 3, 10)]
        [InlineData(4, 5, 18)]
        [InlineData(1, 5, 12)]
        [InlineData(6, 1, 14)]
        public void CalculatePerimeterOfRectangle(int a, int b, int expected)
        {
            Program.CalculatePerimeterOfRectangle(a, b).Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, 4)]
        [InlineData(new[] {1, 7, 3, 4}, 7)]
        [InlineData(new[] {1, 7, 9, 4}, 9)]
        [InlineData(new[] {1, 69, 9, 4}, 69)]
        [InlineData(new[] {-1, -69, -420}, -1)]
        [InlineData(new[] {0, -4}, 0)]
        [InlineData(null, 0)]
        [InlineData(new int[] { }, 0)]
        public void GetMaxNumber(int[] array, int expected)
        {
            Program.GetMaxNumber(array).Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, 5)]
        [InlineData(new[] {1, 7, 9, 9}, 10)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void GetFirstAndLastSum(int[] array, int expected)
        {
            Program.GetFirstAndLastSum(array).Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, new[] {4, 3, 2, 1})]
        [InlineData(new[] {1, 7, 3, 4}, new[] {4, 3, 7, 1})]
        [InlineData(new[] {1, 7, 9, 4}, new[] {4, 9, 7, 1})]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, null)]
        public void ReverseArray(int[] array, int[] expected)
        {
            if (expected == null)
                Program.ReverseArray(array).Should().BeNull();
            else
                Program.ReverseArray(array).Should().ContainInOrder(expected);
        }

        [Theory]
        [InlineData("vilius", "Vilius")]
        [InlineData("milda", "Milda")]
        [InlineData("ginte", "Ginte")]
        [InlineData("giNte", "Ginte")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        public void StringToFirstUpperLetter(string someString, string expected)
        {
            Program.StringToFirstUpperLetter(someString).Should().Be(expected);
        }
    }
}
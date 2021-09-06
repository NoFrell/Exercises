using System;
using Exercises;
using FluentAssertions;
using Xunit;

namespace ProgramTests
{
    public class ExerciseTests
    {
        [Theory]
        [InlineData(2, 3, new[] {2, 3})]
        [InlineData(4, 9, new[] {4, 5, 6, 7, 8, 9})]
        [InlineData(1, 1, new[] {1})]
        [InlineData(-3, 1, new[] {-3, -2, -1, 0, 1})]
        [InlineData(0, 0, new[] {0})]
        public void GetNumbersFromTo(int from, int to, int[] expected)
        {
            Program.GetNumbersFromTo(from, to).Should().HaveCount(expected.Length)
                .And.ContainInOrder(expected);
        }

        [Theory]
        [InlineData("Vilius", "suiliV")]
        [InlineData("Milda", "adliM")]
        [InlineData("Ginte ", " etniG")]
        [InlineData("GiNte", "etNiG")]
        [InlineData("", "")]
        [InlineData(" ", " ")]
        [InlineData(null, null)]
        public void ReverseString(string someString, string expected)
        {
            Program.ReverseString(someString).Should().Be(expected);
        }

        [Theory]
        [InlineData("Vilius Zobela", "V.Z.")]
        [InlineData("Milda    Jakstaite  ", "M.J.")]
        [InlineData("Ginte", null)]
        [InlineData(" Jakstaite", null)]
        [InlineData("", null)]
        [InlineData(" ", null)]
        [InlineData(null, null)]
        public void GetNameInitials(string fullName, string expected)
        {
            Program.GetNameInitials(fullName).Should().Be(expected);
        }

        [Theory]
        [InlineData("39712041234")]
        [InlineData("39812041234")]
        [InlineData("39711041234")]
        [InlineData("39411051234")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void ExtractBirthdateFromPersonalCode(string personalCode)
        {
            DateTime? expected = personalCode switch
            {
                "39712041234" => new DateTime(1997, 12, 4),
                "39812041234" => new DateTime(1998, 12, 4),
                "39711041234" => new DateTime(1997, 11, 4),
                "39411051234" => new DateTime(1994, 11, 5),
                "" => null,
                " " => null,
                null => null,
            };

            Program.ExtractBirthdateFromPersonalCode(personalCode).Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4}, 2.50d)]
        [InlineData(new[] {1, 7, 3, 4}, 3.75d)]
        [InlineData(new[] {1, 7, 9, 4}, 5.25d)]
        [InlineData(new[] {7}, 7.00d)]
        [InlineData(new int[] { }, 0.00d)]
        [InlineData(null, 0.00d)]
        public void GetAverageGrade(int[] grades, double expected)
        {
            Math.Round(Program.GetAverageGrade(grades), 2).Should().Be(expected);
        }

        [Theory]
        [InlineData(330, 10, 297)]
        [InlineData(330, 20, 264)]
        [InlineData(440, 10, 396)]
        [InlineData(440, 20, 352)]
        [InlineData(0, 20, 0)]
        [InlineData(0, 0, 0)]
        public void CalculateDiscount(int originalPrice, int discount, int expected)
        {
            Program.CalculateDiscount(originalPrice, discount).Should().Be(expected);
        }

        [Theory]
        [InlineData(new[] {-5, 1, 5, -10, -3}, new[] {"negative", "positive", "positive", "negative", "negative"})]
        [InlineData(new[] {5, 5, 5}, new[] {"positive", "positive", "positive"})]
        [InlineData(new[] {-5, -5, -5}, new[] {"negative", "negative", "negative"})]
        [InlineData(new[] {0, 0, 0}, new[] {"zero", "zero", "zero"})]
        [InlineData(new[] {-1, 0, 1}, new[] {"negative", "zero", "positive"})]
        [InlineData(new[] {-5, 1, 5, -10, -3, 0}, new[] {"negative", "positive", "positive", "negative", "negative", "zero"})]
        [InlineData(new int[] { }, new string[] { })]
        [InlineData(null, null)]
        public void PositiveNegativeNumbers(int[] input, string[] expected)
        {
            if (expected == null)
                Program.PositiveNegativeNumbers(input).Should().BeNull();
            else
                Program.PositiveNegativeNumbers(input).Should().ContainInOrder(expected);
        }
    }
}
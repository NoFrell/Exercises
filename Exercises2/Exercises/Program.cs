using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Feel free to test out your stuff below...
        }

        // Generate a list of numbers from given number to given number
        // Input: 2, 5
        // Output: a list of integers => 2, 3, 4, 5
        // Input: 9, 15
        // Output: a list of integers => 9, 10, 11, 12, 13, 14, 15
        public static List<int> GetNumbersFromTo(int from, int to)
        {
            // Code here...
            List<int> numbers = new List<int>();
            for (int i = from; i <= to; i++)
            {
                numbers.Add(i);
            }
            return numbers;
            throw new NotImplementedException();
        }

        // Reverse a given string
        // Input: Vilius
        // Output: suiliV
        public static string ReverseString(string someString)
        {
            // Code here...
            if (String.IsNullOrEmpty(someString))
                return someString;
            char[] array = someString.ToCharArray();
            Array.Reverse(array);
            return new String(array);
            throw new NotImplementedException();
        }

        // Get name initials form full name
        // Input: Vilius Zobela
        // Output: V.Z.
        public static string GetNameInitials(string fullName)
        {
            // Code here...
            if (String.IsNullOrEmpty(fullName) || fullName.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count() < 2)
                return null;
            string[] name = fullName.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return name[0][0] + "." + name[1][0] + ".";
            throw new NotImplementedException();
        }

        // Get birth date form personal code
        // Input: 39712043371
        // Output: DateTime object set to date 1997-12-04
        public static DateTime? ExtractBirthdateFromPersonalCode(string personalCode)
        {
            // Code here...
            if (String.IsNullOrEmpty(personalCode) || personalCode.Length != 11)
                return null;
            int year = 0;
            if (int.Parse(personalCode.Substring(1, 2)) > 21)
                year = 1900 + int.Parse(personalCode.Substring(1, 2));
            else
                year = 2000 + int.Parse(personalCode.Substring(1, 2));
            int month = int.Parse(personalCode.Substring(3, 2));
            int day = int.Parse(personalCode.Substring(5, 2));
            return new DateTime(year, month, day);
            throw new NotImplementedException();
        }

        // You're given a grades array (int) find student's average grade
        // Input: { 10, 9, 4, 3 }
        // Output: 6.5
        public static double GetAverageGrade(int[] grades){
            if (grades == null || grades.Length == 0)
                return 0;
            return grades.Average();
            throw new NotImplementedException();
        }

        // You're given the original item price and a discount percentage, calculate the item's price after the discount is applied
        // Input: 330, 10
        // Output: 297
        public static int CalculateDiscount(int originalPrice, int discount)
        {
            // Code here...
            if (originalPrice == 0)
                return 0;
            return originalPrice - originalPrice * discount/100;
            throw new NotImplementedException();
        }

        // Create a program that takes the input int array and returns a string array which corresponds to each number and says whether the number is
        // positive or negative or zero
        // Input: { 1, -3, 5, -10, -5, 0 }
        // Output: { "positive", "negative", "positive", "negative", "negative", "zero" }
        public static string[] PositiveNegativeNumbers(int[] numbers)
        {
            // Code here...
            if (numbers == null)
                return null;
            string[] answer = new string[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                switch (numbers[i])
                {
                    case < 0:
                        answer[i] = "negative";
                        break;
                    case > 0:
                        answer[i] = "positive";
                        break;
                    default:
                        answer[i] = "zero";
                        break;
                }
            }
            return answer;
            throw new NotImplementedException();
        }
    }
}
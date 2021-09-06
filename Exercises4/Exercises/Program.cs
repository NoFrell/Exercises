using System;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Feel free to test out your stuff below...
        }

        // Add PhpSucks to a string
        // Input: tacocat
        // Output: PhpSucks tacocat
        // Input: vilius
        // Output: PhpSucks vilius
        public static string AddPhpSucks(string someString)
        {
            // Code here...
            if (String.IsNullOrEmpty(someString) || !(Char.IsLetter(someString[0])))
                return null;
            return "PhpSucks " + someString;
            throw new NotImplementedException();
        }

        // Repeat given string by given amount of times
        // Input: 3, "ka"
        // Output: "kakaka"
        // Input: 2, "bybis "
        // Output: "bybis bybis "
        public static string RepeatGivenStringTimes(int repeatCount, string input)
        {
            // Code here...
            if (String.IsNullOrEmpty(input) || !(Char.IsLetter(input[0])))
                return null;
            string answer = new string("");
            for (int i = 0; i < repeatCount; i++)
                answer += input;
            return answer;
            throw new NotImplementedException();
        }

        // Check if given number is in given range
        // Input: 100, 69, 429
        // Output: true
        // Input: 13, 1, 10
        // Output: false
        // Input: 10, 10, 10
        // Output: true
        public static bool NumberIsInRange(int number, int from, int to)
        {
            // Code here...
            if (from <= number && number <= to)
                return true;
            return false;
            throw new NotImplementedException();
        }

        // Remove braces from string
        // Input: "[Gays] Vithis"
        // Output: "Gays Vithis"
        // Input: "[Lol sudai]"
        // Output: "Lol sudai"
        // Input: "Kaka"
        // Output: "Kaka"
        public static string RemoveBracesFromString(string input)
        {
            // Code here...
            if (input == null)
                return null;
            input = input.Replace("[", "");
            input = input.Replace("]", "");
            return input;
            throw new NotImplementedException();
        }

        // Swap the first and last element places in array
        // Input: {1,2,5,3}
        // Output: {3,2,5,1}
        // Input: {5,3,7,8,4,2}
        // Output: {2,3,7,8,4,5}
        public static int[] SwapFirstAndLastElementsOfArray(int[] input)
        {
            // Code here...
            if (input == null)
                return null;
            if(input.Length > 0)
                (input[0], input[input.Length - 1]) = (input[input.Length - 1], input[0]);
            return input;
            throw new NotImplementedException();
        }

        // Check how many times given number appears in given array
        // Input: {1,2,1,3,1,1}, 1
        // Output: 4
        // Input: {5,3,7,8,4,2,5}, 3
        // Output: 1
        public static int HowManyTimesValueInArray(int[] input, int value)
        {
            // Code here...
            if (input == null || input.Length < 1)
                return 0;
            int count = new int();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == value)
                    count++;
            }
            return count;
            throw new NotImplementedException();
        }

        // Write a program that prints the numbers from 1 to 100.
        // But for multiples of three print “Fizz” instead of the number and for the multiples of five print “Buzz”.
        // For numbers which are multiples of both three and five print “FizzBuzz”.
        // No tests for this one
        // No googling "how to solve fizzbuzz"
        public static string[] FizzBuzz()
        {
            // Code here...
            string[] answer = new string[100];
            for(int i = 0; i < 100; i++)
            {
                if ((i + 1) % 3 == 0) answer[i] += "Fizz";
                if ((i + 1) % 5 == 0) answer[i] += "Buzz";
                if(answer[i] != null) continue;
                else answer[i] = (i + 1).ToString();
            }
            return answer;
            throw new NotImplementedException();
        }
    }
}
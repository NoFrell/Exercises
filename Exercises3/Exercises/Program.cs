using System;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Feel free to test out your stuff below...
            IsPalindrome("madam");
        }

        // Check if a given string is a Palindrome
        // Input: tacocat
        // Output: true
        // Input: vilius
        // Output: false
        public static bool IsPalindrome(string someString)
        {
            // Code here...
            if (String.IsNullOrEmpty(someString) || someString.Length < 2)
                return false;
            char[] charArray = someString.ToCharArray();
            Array.Reverse(charArray);
            if (someString.ToLower() == new string(charArray).ToLower())
                return true;
            return false;
            throw new NotImplementedException();
        }

        // Count Words in a String
        // Input: your mom is gamer
        // Output: 4
        public static int CountWords(string someString)
        {
            // Code here...
            if (String.IsNullOrEmpty(someString))
                return 0;
            return someString.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length;
            throw new NotImplementedException();
        }

        // How far away from 100
        // Input: 27
        // Output: 73
        // Input: 1000
        // Output: 900
        public static int HowFarFromOneHundred(int number)
        {
            // Code here...
            switch (number)
            {
                case < 100:
                    return 100 - number;
                case > 100:
                    return number - 100;
                default:
                    return 0;
            }
            throw new NotImplementedException();
        }

        // Get the last digit of given number
        // Input: 27
        // Output: 7
        // Input: 3245
        // Output: 5
        public static int GetTheLastDigitOfNumber(int number)
        {
            // Code here...
            return Math.Abs(number % 10);
            throw new NotImplementedException();
        }

        // Check if the given string starts with any of the following hi, hI, Hi, HI
        // Input: hi william
        // Output: true
        // Input: john wick
        // Output: false
        public static bool StartsWithHi(string input)
        {
            // Code here...
            if (String.IsNullOrEmpty(input))
                return false;
            if (input.ToLower().StartsWith("hi"))
                return true;
            return false;
            throw new NotImplementedException();
        }

        // Reverse a number
        // Input: 1234
        // Output: 4321
        // Input: 6969
        // Output: 9696
        public static int ReverseNumber(int input)
        {
            // Code here...
            int mem = 0;
            int reverse = new int();
            while (input != 0)
            {
                mem = input % 10;
                reverse = (reverse * 10) + mem;
                input /= 10;
            }
            return reverse;
            throw new NotImplementedException();
        }

        // Check of many letters 'e' or 'E' are in a string
        // Input: beetroot
        // Output: 2
        // Input: bomzas
        // Output: 0
        public static int HowManyEsInAString(string input)
        {
            // Code here...
            if (String.IsNullOrEmpty(input))
                return 0;
            return input.ToLower().Split('e').Length - 1;
            throw new NotImplementedException();
        }
    }
}
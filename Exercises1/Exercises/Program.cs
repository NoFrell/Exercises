using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Feel free to test out your stuff below...
        }

        // Generate a list of numbers from 1 to 10
        // Input: none
        // Output: a list of integers =>  1, 2 ... 8, 9, 10
        public static List<int> GetNumbersFromOneToTen()
        {
            // Code here...
            List<int> List = new List<int>();
            for(int i = 1; i <= 10; i++)
            {
                List.Add(i);
            }
            return List;
            throw new NotImplementedException();
        }

        // Connect two strings
        // Input: Vilius, Zobela
        // Output: Vilius Zobela
        public static string GetFullName(string firstName, string lastName)
        {
            // Code here...
            if (firstName == null)
                return lastName;
            if (lastName == null)
                return firstName;
            return firstName + " " + lastName;
            throw new NotImplementedException();
        }

        // Calculate the perimeter of a rectangle by formula '2a + 2b'
        // Input: 2, 3
        // Output: 10
        public static int CalculatePerimeterOfRectangle(int a, int b)
        {
            // Code here...
            return 2 * a + 2 * b;
            throw new NotImplementedException();
        }

        // Get the maximum number from an int array
        // Input: { 2, 5, 3, 2, 10, 4 }
        // Output: 10
        public static int GetMaxNumber(int[] array)
        {
            // Code here...
            if (array == null || array.Length == 0)
                return 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
            throw new NotImplementedException();
        }

        // Get the sum of the first and last elements of the array
        // Input: { 2, 5, 3, 2, 10, 4 }
        // Output: 2 + 4 = 6
        public static int GetFirstAndLastSum(int[] array)
        {
            // Code here...
            if (array == null || array.Length == 0)
                return 0;
            return array[0] + array[array.Length-1];
            throw new NotImplementedException();
        }

        // Reverse the integer array
        // Input: { 1, 2, 3, 4 }
        // Output: { 4, 3, 2, 1 }
        public static int[] ReverseArray(int[] array)
        {
            // Code here...
            if(array == null)
            {
                return array;
            }
            int[] reverse = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                reverse[reverse.Length - 1 - i] = array[i];
            }
            return reverse;
            throw new NotImplementedException();
        }

        // Convert the string to first upper letter format
        // Input: vilius
        // Output: Vilius
        public static string StringToFirstUpperLetter(string someString)
        {
            // Code here...
            if (String.IsNullOrEmpty(someString))
            {
                return someString;
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder(someString);
            sb[0] = Char.ToUpper(someString[0]);
            for (int i = 1; i < sb.Length; i++)
            {
                if (Char.IsUpper(sb[i]))
                    sb[i] = Char.ToLower(sb[i]);
            }
            return sb.ToString();
            throw new NotImplementedException();
        }
    }
}
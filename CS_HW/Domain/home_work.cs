using System;

namespace PalindromeCheckerLibrary
{
    public class PalindromeChecker
    {
        public static bool IsPalindrome(int number)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number = number / 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}
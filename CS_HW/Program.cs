using PalindromeCheckerLibrary;
using System;

namespace PalindromeCheckerApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isPalindrome = PalindromeCheckerLibrary.PalindromeChecker.IsPalindrome(number);

            if (isPalindrome)
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }
    }
}
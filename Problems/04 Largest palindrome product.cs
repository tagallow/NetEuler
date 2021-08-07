using System;
using System.Linq;

/* 
A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
    https://projecteuler.net/problem=4  */

namespace NetEuler
{
    static class LargestPalindrome
    {
        public static void Solve()
        {
            int largest = 0;
            int start = 900;
            int end = 999;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    int k = j * i;
                    if (isPalindrome(k))
                    {
                        largest = k > largest ? k : largest;
                    }
                }
            }
            Console.WriteLine("Solution: {0}", largest);
        }
        private static bool isPalindrome(int n)
        {
            bool result = true;

            char[] s = new string(n.ToString()).ToCharArray();
            char[] r = s.Reverse().ToArray();

            if (new string(s) != new string(r))
            {
                result = false;
            }
            return result;
        }
    }
}
using System;

/* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.
    https://projecteuler.net/problem=1  */

namespace NetEuler
{
    static class QuickSort
    {
        public static void Solve()
        {
            string s = "987654321";
            
            Console.WriteLine("Solution: {0}", sort(s));
        }
        /// <summary>
        /// Sort a string using quicksort
        /// </summary>
        public static string sort(string s)
        {
            string left = "";
            string right = "";
            string center = "";
            char pivot = s[0];

            foreach(char c in s)
            {
                if(c < pivot)
                {
                    left += c;
                }
                else if (c > pivot)
                {
                    right += c;
                }
                else
                {
                    center += c;
                }
            }
            if(left.Length > 1)
            {
                left = sort(left);
            }
            if (right.Length > 1)
            {
                right = sort(right);
            }
            return left + center + right;

        }
    }
}
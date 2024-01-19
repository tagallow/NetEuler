using System;

/* If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
    The sum of these multiples is 23.
    Find the sum of all the multiples of 3 or 5 below 1000.
    https://projecteuler.net/problem=1  */

namespace NetEuler
{
    static class Mult3And5
    {
        // the sum of all the multiples of 3 or 5 below 1000
        public static void Solve()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Solution: {0}", sum);
        }
    }
}
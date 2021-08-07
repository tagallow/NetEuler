using System;
using System.Collections.Generic;
using System.Linq;

/*  By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

    What is the 10 001st prime number?
    https://projecteuler.net/problem=7  */


namespace NetEuler
{
    static class Prime10001
    {
        public static void Solve()
        {
            var p = Tools.GetPrimes(200000);
            Console.WriteLine("Solution: {0}", p[10000]);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

/* 
    The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

    Find the sum of all the primes below two million.
    https://projecteuler.net/problem=10  */


namespace NetEuler
{
    static class SumOfPrimes
    {
        public static void Solve()
        {
            long sum = 0;
            int sieveMax = 2000003;
            List<int> primes = Tools.GetPrimes(sieveMax);
            foreach (int n in primes)
            {
                sum += n;
            }
            Console.WriteLine("Solution: {0}", sum);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

/* The prime factors of 13195 are 5, 7, 13 and 29.

    What is the largest prime factor of the number 600851475143 ?
    https://projecteuler.net/problem=3  */


namespace NetEuler
{
    static class LargestPrimeFactor
    {
        public static void Solve()
        {
            List<int> factors = new List<int>();
            List<int> primes = Tools.GetPrimes();
            int target = 13195;
            foreach(int p in primes)
            {
                if(p > target/2)
                {
                    break;
                }
                if(target % p == 0)
                {
                    factors.Add(p);
                }
            }
            Console.WriteLine("Solution: {0}", factors.Max());
        }
    }
}
using System;
using System.Collections.Generic;
namespace NetEuler
{
    static class Tools
    {
        public static List<int> GetPrimes(int max = 104730)
        {
            return SieveEratosthenes2(max);
        }
        // from https://brilliant.org/wiki/sieve-of-eratosthenes/
        // Sieve of Eratosthenes to calculate primes up to max
        private static List<int> SieveEratosthenes2(int max)
        {
            bool[] sieve = new bool[max];
            List<int> result = new List<int>();

            for (int i = 0; i < max; i++)
            {
                sieve[i] = true;
            }
            sieve[0] = sieve[1] = false;
            int p = 2;
            while (Math.Pow(p, 2) <= max)
            {
                for (int i = (p + p); i < max; i += p)
                {
                    sieve[i] = false;
                }
                for (int i = p; i < max; i++)
                {
                    if (sieve[i] && i > p)
                    {
                        p = i;
                        break;
                    }
                }
            }
            for (int i = 0; i < max; i++)
            {
                if (sieve[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
        private static bool isEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
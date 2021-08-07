using System.Linq;
using System;
using System.IO;
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

        #region unused
        /* private static List<int> SieveEratosthenes(int max)
        {
            bool[] N = new bool[max];
            for (int i = 0; i < max; i++)
                N[i] = true;
            N[0] = N[1] = false;

            for (int i = 2; i < max; i++)
            {
                if (N[i])
                {
                    for (int j = (2 * i); j < max; j += i)
                    {
                        N[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < max; i++)
            {
                if (N[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
        private static int[] GetPrimesFile()
        {
            string[] file = File.ReadAllLines(@"Tools\1kprimes.txt")[0].Split(',');
            int[] primes = Array.ConvertAll(file, int.Parse);
            return primes;
        }
        public static int[] GetPrimes10kFile()
        {
            string[] file = File.ReadAllLines(@"Tools\10kprimes.txt")[0].Split(',');
            int[] primes = Array.ConvertAll(file, int.Parse);
            return primes;
        } */
        #endregion

    }
}
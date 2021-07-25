using System;
using System.Collections.Generic;
using System.Linq;

/* 
    What is the value of the first triangle number to have over five hundred divisors?
    https://projecteuler.net/problem=12  */


namespace NetEuler
{
    static class HighlyDivisibleTriangularNumber
    {
        public static void Solve()
        {
            int currentIndex = 0;
            long currentTriNumber = 1;
            int factorCount = 0;

            while (factorCount < 500)
            {
                currentIndex++;
                currentTriNumber = getNextTriNum(currentIndex);
                factorCount = getFactorCount3(currentTriNumber);
            }

            Console.WriteLine("Solution: {0}", currentTriNumber);
        }

        static long getNextTriNum(int currentIndex)
        {
            long sum = 0;
            for (int j = 1; j <= currentIndex; j++)
            {
                sum += j;
            }
            return sum;
        }
        public static int getFactorCount3(long n)
        {
            int count = 2;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    count++;
                    if (Math.Pow(i, 2) != n)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int getFactorCountFast(long n)
        {
            List<int> primes = Tools.GetPrimes();
            int count = 1;

            for (int j = 0; j <= n / 2; j++)
            {
                if (n % primes[j] == 0)
                {
                    count++;
                }
            }
            int totalSum = 1;
            for (int j = 0; j < count; j++)
            {
                totalSum *= (count + 1);
            }
            return totalSum;
        }
        static int getFactorCount(long n)
        {
            int count = 1;

            for (long j = 1; j <= n / 2; j++)
            {
                if (n % j == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
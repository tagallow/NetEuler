using System;
using System.Collections.Generic;
using System.Linq;

/* 
    2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    https://projecteuler.net/problem=5  */


namespace NetEuler
{
    static class SmallestMultiple
    {
        public static void Solve()
        {
            int n = 2520;
            bool done = false;
            bool fail = false;
            while (!done)
            {
                fail = false;
                for (int i = 1; i <= 20 && !fail; i++)
                {
                    if (n % i != 0)
                    {
                        fail = true;
                    }
                }
                if (!fail)
                {
                    done = true;
                }
                else
                {
                    n++;
                }
            }
            Console.WriteLine("Solution: {0}", n);
        }
        public static void CorrectSolution()
        {
            //https://projecteuler.net/overview=005
            int k = 20;
            int N = 1;
            int i = 0;
            bool check = true;
            double limit = Math.Sqrt(k);
            List<int> p = Tools.GetPrimes();
            int[] a = new int[k];
            while (p[i] <= k)
            {
                a[i] = 1;
                if (check)
                {
                    if (p[i] <= limit)
                    {
                        a[i] = (int)Math.Floor(Math.Log(k) / Math.Log(p[i]));
                    }
                    else
                    {
                        check = false;
                    }
                }
                N *= (int)Math.Pow(p[i], a[i]);
                i++;
            }
            Console.WriteLine("Solution: {0}", N);

        }
    }
}
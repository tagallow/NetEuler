using System;
using System.Collections.Generic;
using System.Linq;

/* 
    A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

    a2 + b2 = c2
    For example, 32 + 42 = 9 + 16 = 25 = 52.

    There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    Find the product abc.
    https://projecteuler.net/problem=9 */


namespace NetEuler
{
    static class SpecialPythagoreanTriplet
    {
        // runs a brute force search for the solution. checks a, b, and c, from 1 to 1000. 
        public static void Solve()
        {
            bool solved = false;
            long product = 0;
            for (int a = 1; a < 1000 && !solved; a++)
            {
                for (int b = 1; b < 1000 && !solved; b++)
                {
                    for (int c = 1; c < 1000 && !solved; c++)
                    {
                        if (cIsMax(a, b, c) && correctSum(a, b, c) && isTriplit(a, b, c))
                        {
                            solved = true;
                            Console.WriteLine("Solution 1 found: {0} + {1} + {2} == 1000", a, b, c);
                            Console.WriteLine("Solution 2 found: {0} + {1} = {2}", Math.Pow(a, 2), Math.Pow(b, 2), Math.Pow(c, 2));
                            product = a * b * c;
                        }
                    }
                }
            }
            Console.WriteLine("Process Complete: {0}", product);
        }
        // check if c is the largest of the three numbers
        public static bool cIsMax(int a, int b, int c)
        {
            return c > a && c > b;
        }
        // check if a^2 + b^2 = c^2
        public static bool isTriplit(int a, int b, int c)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
        public static bool correctSum(int a, int b, int c)
        {
            return (a + b + c) == 1000;
        }
    }
}
/* public static void Solve2()
        {
            bool solved = false;
            long product = 0;
            for (int a = 1000; a > 0 && !solved; a--)
            {
                for (int b = 1000; b > 0 && !solved; b--)
                {
                    for (int c = 1000; c > 0 && !solved; c--)
                    {
                        if (cIsMax(a, b, c) && correctSum(a, b, c) && isTriplit(a, b, c))
                        {
                            solved = true;
                            Console.WriteLine("Solution 1 found: {0} + {1} + {2} == 1000", a, b, c);
                            Console.WriteLine("Solution 2 found: {0} + {1} = {2}", Math.Pow(a, 2), Math.Pow(b, 2), Math.Pow(c, 2));
                            product = a * b * c;
                        }
                    }
                }
            }
            Console.WriteLine("Process Complete: {0}", product);
        } */

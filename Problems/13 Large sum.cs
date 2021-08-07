using System.IO;
using System;

/* 
    Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
    https://projecteuler.net/problem=13  */


namespace NetEuler
{
    static class LargeSum
    {
        public static void Solve()
        {
            string[] file = File.ReadAllLines("Tools/largeSum.txt");
            BigInteger sum = new BigInteger(0);

            foreach (string n in file)
            {
                sum += new BigInteger(n, 10);
            }
            string result = sum.ToString().Substring(0, 10);
            Console.WriteLine(result);
        }
    }
}
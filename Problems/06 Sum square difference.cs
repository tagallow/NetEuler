using System;

/* https://projecteuler.net/problem=6 */


namespace NetEuler
{
    static class SumSquareDifference
    {
        public static void Solve()
        {
            int max = 100;
            int difference = SquareOfSums(max) - SumOfSquares(max);
            Console.WriteLine("Solution: {0}", difference);
        }
        private static int SumOfSquares(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                sum += (int)Math.Pow(i, 2);
            }
            return sum;
        }
        private static int SquareOfSums(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                sum += i;
            }
            sum = (int)Math.Pow(sum, 2);
            return sum;
        }
    }
}
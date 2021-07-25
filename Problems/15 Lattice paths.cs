using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

/* 
    Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
    How many such routes are there through a 20×20 grid?
    https://projecteuler.net/problem=15  */


namespace NetEuler
{
    static class LatticePaths
    {
        // static long numPaths = 0;
        static int size = 2;

        static long numPaths = 0;
        public static void Solve()
        {
            Move(0, 0);
            Console.WriteLine("Number of paths: " + numPaths);
        }
        private static void Move(int x, int y)
        {
            if (x == size && y == size)
            {
                numPaths++;
                return;
            }
            if (x < size)
            {
                Move(x + 1, y);
            }
            if (y < size)
            {
                Move(x, y + 1);
            }
            return;
        }

        
    }
    static class LatticePaths2
    {
        //static int size = 20;

        static long numPaths = 0;
        public static void Solve()
        {
            
            Console.WriteLine("Number of paths: " + numPaths);
        }
    }
}
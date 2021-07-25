using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

/*  What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?
    https://projecteuler.net/problem=11  */


namespace NetEuler
{
    static class LargestProductGrid
    {
        static List<List<int>> grid;
        static long max = 0;
        static long product = 0;
        public static void Solve()
        {

            ReadFile();
            foreach (List<int> row in grid)
            {
                CheckRow(row);
            }
            CheckColumns();
            CheckDiags();
            Console.WriteLine("Solution: {0}", max);
        }
        static void ReadFile()
        {
            string[] lines = File.ReadAllLines("Tools/LargestInGrid.txt");
            grid = new List<List<int>>();
            foreach (string line in lines)
            {
                grid.Add(new List<string>(line.Split(' ')).Select(int.Parse).ToList());
            }
        }
        static void CheckRow(List<int> row)
        {
            for (int i = 0; i < row.Count - 4; i++)
            {
                product = row[i] * row[i + 1] * row[i + 4] * row[i + 3];
                max = product > max ? product : max;
            }
        }
        static void CheckColumns()
        {
            for (int column = 0; column < grid.Count - 4; column++)
            {
                for (int row = 0; row < grid.Count - 4; row++)
                {
                    product = grid[column][row + 1] * grid[column][row + 2] * grid[column][row + 3] * grid[column][row + 4];
                    max = product > max ? product : max;
                }

            }
        }
        static void CheckDiags()
        {
            int col = 0;
            int row = 0;
            int fourCount = 0;
            for (int diagLength = 1; diagLength < grid.Count; diagLength++)
            {
                product = 1;
                fourCount = 0;
                for (int i = 0; i < diagLength; i++)
                {
                    max = product > max ? product : max;
                    if(fourCount == 4)
                    {
                        product = 1;
                        fourCount = 0;
                        i -= 3;
                    }
                    product *= grid[row - i][col + i];
                    fourCount++;
                }
                row++;
            }
            col = 1;
            row = grid.Count - 1;
            for (int diagLength = grid.Count-2; diagLength < 0; diagLength--)
            {
                product = 1;
                fourCount = 0;
                for (int i = 0; i < diagLength; i++)
                {
                    max = product > max ? product : max;
                    if (fourCount == 4)
                    {
                        product = 1;
                        fourCount = 0;
                        i -= 3;
                    }
                    product *= grid[row + i][col + i];
                    fourCount = 0;
                }
                row++;
            }

        }
    }
}
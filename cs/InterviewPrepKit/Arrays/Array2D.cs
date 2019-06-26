using System;
using System.Collections.Generic;

namespace HackerRank.InterviewPrepKit.Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/2d-array/problem
    /// </summary>
    public static class Array2D
    {
        public static void Run()
        {
            var tests = new List<int[][]>
            {
                new[]
                {
                    new[] {-9, -9, -9, 1, 1, 1},
                    new[] {0, -9, 0, 4, 3, 2},
                    new[] {-9, -9, -9, 1, 2, 3},
                    new[] {0, 0, 8, 6, 6, 0},
                    new[] {0, 0, 0, 0, -2, 0},
                    new[] {0, 0, 1, 2, 4, 0},
                },
                new[]
                {
                    new[] {1, 1, 1, 0, 0, 0},
                    new[] {0, 1, 0, 0, 0, 0},
                    new[] {1, 1, 1, 0, 0, 0},
                    new[] {0, 0, 2, 4, 4, 0},
                    new[] {0, 0, 0, 2, 0, 0},
                    new[] {0, 0, 1, 2, 4, 0},
                },
            };
            foreach (var testArray in tests)
            {
                Console.WriteLine(hourglassSum(testArray));                
            }
        }

        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {
            int xLen = 4, yLen = 4, max = 0, sum;
            bool first = true;
            for (int x = 0; x < xLen; x++)
            {
                for (int y = 0; y < yLen; y++)
                {
                    sum =   arr[x][y] + arr[x][y + 1] + arr[x][y + 2] +
                            arr[x + 1][y + 1] +
                            arr[x + 2][y] + arr[x + 2][y + 1] + arr[x + 2][y + 2];
                    if (first)
                    {
                        first = false;
                        max = sum;
                        continue;
                    }
                    if (sum > max) max = sum;
                }
            }
            return max;
        }
    }
}
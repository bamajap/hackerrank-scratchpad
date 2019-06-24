using System;

namespace Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    /// </summary>
    internal static class LeftRotation
    {
        internal static void Run()
        {
            Console.WriteLine(string.Join(", ", rotLeft(new[] {1, 2, 3, 4, 5}, 2)));
            Console.WriteLine(string.Join(", ", rotLeft(new[] {1, 2, 3, 4, 5}, 4)));
        }

        // Complete the rotLeft function below.
        private static int[] rotLeft(int[] a, int d)
        {
            int aLen = a.Length;
            if (d == aLen) return a;

            var result = new int[aLen];
            for (int i = 0; i < aLen; i++)
            {
                result[i] = a[(d + i)%aLen];
            }
            return result;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/max-array-sum/problem
    /// </summary>
    internal static class MaxArraySum
    {
        internal static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int res = maxSubsetSum(arr);

            Console.WriteLine(res);
        }

        private static int maxSubsetSum(int[] arr)
        {
            var length = arr.Length;
            switch (length)
            {
                case 0:
                    throw new NotSupportedException("The array size must be greater than 1.");
                case 1:
                    return arr[0];
            }

            var max = new List<int> { arr[0], Math.Max(arr[0], arr[1]) };
            for (int i = 2; i < length; i++)
            {
                var a = new int[3];
                a[0] = arr[i];              // Subset containing just the value at the current position.
                a[1] = max[i - 1];          // Compare against the calculated max from the previous position.
                a[2] = arr[i] + max[i - 2]; // Compare against the calculated max composed of the current value + calculated max from two positions prior.
                max.Add(a.Max());
            }
            return max.Last();
        }
    }
}
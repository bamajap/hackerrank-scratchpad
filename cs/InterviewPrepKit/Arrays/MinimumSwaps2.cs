using System;

namespace Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/minimum-swaps-2/problem
    /// </summary>
    internal static class MinimumSwaps2
    {
        internal static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
        }

        private static int minimumSwaps(int[] arr)
        {
            var swapCnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i + 1) continue;

                for (int ii = i + 1; ii < arr.Length; ii++)
                {
                    if (arr[ii] != i + 1) continue;
                    swapCnt++;
                    // Swap values
                    int temp = arr[i];
                    arr[i] = arr[ii];
                    arr[ii] = temp;
                    break;
                }
            }

            return swapCnt;
        }
    }
}
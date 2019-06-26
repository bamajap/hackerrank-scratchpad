using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPrepKit.Arrays
{
    public static class ArrayManipulation
    {
        private static long arrayManipulation(int n, int[][] queries)
        {
            // Brute force
            var max = 0L;
            var arr = new long[n];
            for (int q = 0; q < queries.Length; q++)
            {
                var left = queries[q][0]-1;
                var right = queries[q][1]-1;
                var addend = queries[q][2];
                for (int i = left; i <= right; i++)
                {
                    arr[i] += addend;
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
            }
            return max;
        }

        public static void Run()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);
        }
    }
}

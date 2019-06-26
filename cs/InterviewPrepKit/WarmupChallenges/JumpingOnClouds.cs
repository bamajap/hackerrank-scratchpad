using System;

namespace WarmupChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    /// </summary>
    internal static class JumpingOnClouds
    {
        internal static void Run()
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }

        private static int jumpingOnClouds(int[] clouds)
        {
            int jumps = 0, n = clouds.Length;
            for (int c = 0; c < n - 1; )
            {
                var i = (c == (n - 2)) ? c + 1 : c + 2;
                jumps++;
                c = (clouds[i] == 1) ? i - 1 : i;
            }
            return jumps;
        }
    }
}
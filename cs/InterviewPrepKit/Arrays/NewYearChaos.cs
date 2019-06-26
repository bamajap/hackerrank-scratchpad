using System;

namespace HackerRank.InterviewPrepKit.Arrays
{
    public static class NewYearChaos
    {
        public static void Run()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                minimumBribes(q);
            }
        }

        private static void minimumBribes(int[] q)
        {
            int qLen = q.Length, temp, bribes = 0, displacement = 0;

            for (int i = 0; i < qLen - 2; i++)
            {
                displacement = q[i] - (i + 1);
                if (displacement > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }
            for (int n = qLen - 1; n > 0; n--)
            {
                bool sorted = true;
                for (int i = 0; i < n; i++)
                {
                    if (q[i] > q[i + 1])
                    {
                        sorted = false;
                        temp = q[i];
                        q[i] = q[i + 1];
                        q[i + 1] = temp;
                        bribes++;
                    }
                }
                if (sorted) break;
            }
            Console.WriteLine(bribes);
        }
    }
}
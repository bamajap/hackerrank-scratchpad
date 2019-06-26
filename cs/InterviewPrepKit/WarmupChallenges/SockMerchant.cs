using System;

namespace HackerRank.InterviewPrepKit.WarmupChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sock-merchant/problem
    /// </summary>
    public static class SockMerchant
    {
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            if (n < 2) return 0;
            var pairCnt = 0;
            // Sort the socks
            int sockCnt;
            for (int i = 0; i < n - 1; i++)
            {
                var testVal = ar[i];
                sockCnt = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if ((ar[j] != testVal) || (ar[j] == -1))
                    {
                        continue;
                    }
                    sockCnt++;
                    ar[j] = -1;
                }
                pairCnt += (sockCnt / 2);
            }

            return pairCnt;
        }
    }
}
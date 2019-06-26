using System;

namespace HackerRank.InterviewPrepKit.WarmupChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/counting-valleys/problem
    /// </summary>
    public static class CountingValleys
    {
        public static void Run()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);
        }

        private static int countingValleys(int n, string s)
        {
            // n = 8
            // s = "UDDDUDUU"
            var valleyCnt = 0;
            var elevation = 0;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    elevation++;
                    if (elevation == 0) valleyCnt++;
                }
                else elevation--;
            }
            return valleyCnt;
        }
    }
}
using System;

namespace WarmupChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/repeated-string/problem
    /// </summary>
    internal static class RepeatedString
    {
        internal static void Run()
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }

        private static long repeatedString(string s, long n)
        {
            long result = 0;
            var target = 'a';
            var counter = 0;
            foreach (var c in s)
            {
                if (c == target) counter++;
            }
            var repeats = n/s.Length;
            result += (repeats*counter);

            var substring = s.Substring(0, Convert.ToInt32(n%s.Length));
            if (substring.Length > 0)
            {
                foreach (var c in substring)
                {
                    if (c == target) result++;
                }
            }
            return result;
        }
    }
}
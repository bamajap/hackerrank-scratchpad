using System;

namespace HackerRank.InterviewPrepKit.Sorting
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-bubble-sort/problem
    /// </summary>
    public static class CtciBubbleSort
    {
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            BubbleSort(a);
        }

        static void BubbleSort(int[] a)
        {
            int totalSwaps = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int swaps = 0;
                for (int j = 0; j < a.Length - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                        swaps++;
                        totalSwaps++;
                    }
                }
                if (swaps == 0) break;
            }
            Console.WriteLine("Array is sorted in {0} swaps.", totalSwaps);
            Console.WriteLine("First Element: {0}", a[0]);
            Console.WriteLine("Last Element: {0}", a[a.Length - 1]);
        }
    }
}
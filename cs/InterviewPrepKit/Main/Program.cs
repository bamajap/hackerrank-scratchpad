using System;
using HackerRank.InterviewPrepKit.WarmupChallenges;
using HackerRank.InterviewPrepKit.Arrays;
using HackerRank.InterviewPrepKit.DynamicProgramming;
using HackerRank.InterviewPrepKit.Sorting;


namespace Main
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var quit = false;
            do
            {
                Run();
                Console.WriteLine(Environment.NewLine + "Press 'q' to quit...");
                var key = Console.ReadKey();
                if (key.KeyChar == 'q')
                {
                    quit = true;
                }
            } while (!quit);
        }

        static void Run()
        {
            #region Warmup Challenges

            //SockMerchant.Run();
            //JumpingOnClouds.Run();
            //CountingValleys.Run();
            //RepeatedString.Run();

            #endregion Warmup Challenges

            #region Arrays

            //Array2D.Run();
            //LeftRotation.Run();
            //MinimumSwaps2.Run();
            //NewYearChaos.Run();

            #endregion Arrays

            #region Dynamic Programming

            //MaxArraySum.Run();

            #endregion Dynamic Programming

            #region Sorting

            //CtciBubbleSort.Run();

            #endregion Sorting
        }
    }
}

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Array2D.Run();
            LeftRotation.Run();

            Console.WriteLine(Environment.NewLine + "Press any key to exit...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    /// </summary>
    internal static class LeftRotation
    {
        internal static void Run()
        {
            Console.WriteLine(string.Join(", ", rotLeft(new[] {1, 2, 3, 4, 5}, 2)));
            Console.WriteLine(string.Join(", ", rotLeft(new[] {1, 2, 3, 4, 5}, 4)));
        }

        // Complete the rotLeft function below.
        private static int[] rotLeft(int[] a, int d)
        {
            int aLen = a.Length;
            if (d == aLen) return a;

            var result = new int[aLen];
            for (int i = 0; i < aLen; i++)
            {
                result[i] = a[(d + i)%aLen];
            }
            return result;
        }
    }
}

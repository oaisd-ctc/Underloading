using Underloading;
using System;

namespace Underloading
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] testArray1 = {1, 4, 18, 7, 9, 53};
            int[] testArray2 = {2, 5, 19, 8, 10, 54};

            int ans = ArrayUtils.SubArray(testArray1, testArray2);

            Console.WriteLine("The answer is: " + ans);
        }
    }
}

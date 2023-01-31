using ArrayUtils;
using System;

namespace Underloading
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};
            double[] testArray2 = {2.2, 5.5, 19.19, 8.8, 10.10, 54.54};

            double ans = submissiveArray.Sub(testArray1, testArray2);

            Console.WriteLine(ans);
        }
    }
}

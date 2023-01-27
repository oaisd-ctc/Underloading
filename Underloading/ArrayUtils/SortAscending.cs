using System;
using System.Collections.Generic;

namespace ArrayUtils
{
    public static class ascent
    {
        public static string SortAscending(int[] x)
        {
            int t = 0;

            for (int i = 0; i <= x.Length - 1; i++)
            {
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            string xString = thing.ArrayToString(x);
            return xString;
        }

        public static string SortAscending(double[] x)
        {
            int t = 0;

            for (int i = 0; i <= x.Length - 1; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        t = (int) x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            string xString = thing.ArrayToString(x);
            return xString;
        }
    }
}
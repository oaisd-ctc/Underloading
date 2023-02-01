using System;
using System.Collections.Generic;

namespace ArrayUtils
{
    public static class descent
    {
        /// <summary>
        /// <c>SortDescending</c> sorts an integer array in descending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted integer array</strong></returns>
        /// </summary>
        public static string SortDescending(int[] x)
        {
            int t = 0;

            for (int i = 0; i <= x.Length -1; i++)
            {
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[i] < x[j])
                    {
                        t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            string xString = ArrayToString(x);
            return xString;
        }

        /// <summary>
        /// <c>SortDescending</c> sorts a double array in descending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted double array</strong></returns>
        /// </summary>
        public static string SortDescending(double[] x)
        {
            int t = 0;

            for (int i = 0; i <= x.Length -1; i++)
            {
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[i] < x[j])
                    {
                        t = (int) x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            string xString = ArrayToString(x);
            return xString;
        }

        public static string ArrayToString(int[] x)
        {
            string arrayToString = "{ ";
            int i = 0;

            foreach (int item in x)
            {
                if (i < x.Length - 1)
                {
                    arrayToString += $"{Convert.ToString(x.GetValue(i))}, ";
                }
                else
                {
                    arrayToString += $"{Convert.ToString(x.GetValue(i))} }}";
                }
                i++;
            }
            return arrayToString;
        }

        public static string ArrayToString(double[] x)
        {
            string arrayToString = "{ ";
            int i = 0;

            foreach (int item in x)
            {
                if (i < x.Length - 1)
                {
                    arrayToString += $"{Convert.ToString(x.GetValue(i))}, ";
                }
                else
                {
                    arrayToString += $"{Convert.ToString(x.GetValue(i))} }}";
                }
                i++;
            }
            return arrayToString;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ArrayUtils
{
    public static class ascent
    {
        /// <summary>
        /// <c>SortAscending</c> sorts an integer array in ascending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted integer array</strong></returns>
        /// </summary>
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
            string xString = OutputToString.ConvertToString(x);
            return xString;
        }

        /// <summary>
        /// <c>SortAscending</c> sorts a double array in ascending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted double array</strong></returns>
        /// </summary>
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
            string xString = OutputToString.ConvertToString(x);
            return xString;
        }
    }
}
using System;
using System.Collections.Generic;

namespace ArrayUtils
{
    public static class descent
    {
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
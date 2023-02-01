namespace ArrayUtils
{
    public static class submissiveArray
    {
        /// <summary>
        /// <c>SubArray</c> subtracts two integer arrays from each other.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>Two integer arrays</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the difference of the two arrays</strong></returns>
        /// </summary>
        public static int SubArray(int[] x, int[] y)
        {
            int subtracted = 0;
            int subtracted2 = 0;
            int i = 0;
            int r = 0;

            while (i < x.Length && r < y.Length)
            {
                if (i <= x.Length)
                {
                    subtracted += x[i] - y[i];
                    i++;
                }
                else if (r <= y.Length)
                {
                    subtracted2 += x[r] - y[r];
                    r++;
                }
            }
            return subtracted - subtracted2;
        }

        /// <summary>
        /// <c>SubArray</c> subtracts two double arrays from each other.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>Two double arrays</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the difference of the two arrays</strong></returns>
        /// </summary>
        public static double SubArray(double[] x, double[] y)
        {
            double subtracted = 0;
            double subtracted2 = 0;
            int i = 0;
            int r = 0;

            while (i <= x.Length)
            {
                if(i <= x.Length && r < y.Length)
                {
                    subtracted += x[i] - y[i];
                    i++;
                }
                else if (r <= y.Length)
                {
                    subtracted2 += x[r] - y[r];
                    r++;
                }
            }
            return subtracted - subtracted2;
        }
    }
}
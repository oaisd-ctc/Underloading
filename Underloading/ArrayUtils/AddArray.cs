namespace ArrayUtils
{
    public class addthemarrays
    {
        /// <summary>
        /// <c>AddArray (int)</c> adds two integer arrays together.
        /// <para>
        /// Literally just adds two integer arrays together.
        /// </para>
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>Integer array 1.</em></para></description></item>
        /// <item><description><para><em>Integer array 2.</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the product of the two arrays</strong></returns>
        /// </summary>
        public static int AddArray(int[] x, int[] y)
        {
            int added = 0;
            int added2 = 0;
            int i = 0;
            int r = 0;

            while (i < x.Length && r < y.Length)
            {
                if (i <= x.Length)
                {
                    added += x[i] + y[i];
                    i++;
                }
                else if (r <= y.Length)
                {
                    added2 += x[r] + y[r];
                    r++;
                }
            }
            return added + added2;
        }

        /// <summary>
        /// <c>AddArray (int)</c> adds two double arrays together.
        /// <para>
        /// Literally just adds two double arrays together.
        /// </para>
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>Double array 1.</em></para></description></item>
        /// <item><description><para><em>Double array 2.</em></para></description></item>
        /// </list>
        /// <returns><strong>A double containing the product of the arrays</strong></returns>
        /// </summary>
        public static double AddArray(double[] x, double[] y)
        {
            double added = 0;
            double added2 = 0;
            int i = 0;
            int r = 0;

            while (i <= x.Length - 1)
            {
                if(i <= x.Length && r < y.Length)
                {
                    added = x[i] + y[i];
                    i++;
                }
                else if (r <= y.Length)
                {
                    added2 += x[r] + y[r];
                    r++;
                }
            }
            return added + added2;
        }
    }
}
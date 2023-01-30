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
        /// </summary>
        public static int AddArray(int[] x, int[] y)
        {
            int added = 0;
            int i = 0;

            while (i <= x.Length -1)
            {
                added = x[i] + y[i];
                i++;
            }
            return added;
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
        /// </summary>
        public static double AddArray(double[] x, double[] y)
        {
            double added = 0;
            int i = 0;

            while (i <= x.Length -1)
            {
                added = x[i] + y[i];
                i++;
            }
            return added;
        }
    }
}
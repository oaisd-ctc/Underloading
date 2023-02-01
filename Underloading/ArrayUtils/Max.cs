namespace ArrayUtils
{
    public static class macks
    {
        /// <summary>
        /// <c>Max</c> gets the max number from an integer array.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the maximum of the integer array</strong></returns>
        /// </summary>
        public static int Max(int[] x)
        {
            int max = x[0];
            int i = 0;

            foreach(int y in x)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
                i++;
            }
            return max;
        }

        /// <summary>
        /// <c>Max</c> gets the max of a double array.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>A double containing the maximum of the double array</strong></returns>
        /// </summary>
        public static double Max(double[] x)
        {
            double max = x[0];
            int i = 0;

            foreach(int y in x)
            {
                if (x[i] > max)
                {
                    max = x[i];
                }
                i++;
            }
            return max;
        }
    }
}
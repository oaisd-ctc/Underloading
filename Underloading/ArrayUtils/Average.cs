namespace ArrayUtils
{
    public static class averaging
    {
        /// <summary>
        /// <c>Average</c> gets the average of an array.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array populated with numbers</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the average of the integer array</strong></returns>
        /// </summary>
        public static double Average(int[] x)
        {
            double ans = 0.0;
            int i = 0;
            foreach(int y in x)
            { 
                ans += x[i];
                i++;
            }
            return ans / x.Length;
        }

        /// <summary>
        /// <c>Average</c> gets the average of an array.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array populated with numbers</em></para></description></item>
        /// </list>
        /// <returns><strong>A double containing the average of the double array</strong></returns>
        /// </summary>
        public static double Average(double[] x)
        {
            double ans = 0.0;
            int i = 0;
            foreach(int y in x)
            {
                ans += x[i];
                i++;
            }
            return ans / x.Length;
        }
    }
}
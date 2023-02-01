namespace ArrayUtils
{
    public static class minnie
    {
        /// <summary>
        /// <c>Min</c> gets the minimum number from an integer array.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the minimum of the integer array</strong></returns>
        /// </summary>
        public static int Min(int[] x)
        {
            int min = x[0];
            int i = 0;

            foreach(int y in x)
            {
                if (x[i] < min)
                {
                    min = x[i];
                }
                i++;
            }
            return min;
        }

        /// <summary>
        /// <c>Min</c> gets the minimum number from a double array.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>A double containing the minimum of the double array</strong></returns>
        /// </summary>
        public static double Min(double[] x)
        {
            double min = x[0];
            int i = 0;

            foreach(int y in x)
            {
                if (x[i] < min)
                {
                    min = x[y];
                }
                i++;
            }
            return min;
        }
    }
}
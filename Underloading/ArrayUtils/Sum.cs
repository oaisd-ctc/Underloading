namespace ArrayUtils
{
    public static class summarizing
    {
        /// <summary>
        /// <c>Sum</c> adds all the numbers from an integer array together.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the sum of the numbers in the array</strong></returns>
        /// </summary>
        public static int Sum(int[] x)
        {
            int sum = 0;
            int i = 0;

            foreach(int y in x)
            {
                sum = sum + x[i];
                i++;
            }
            return sum;
        }
        /// <summary>
        /// <c>Sum</c> adds all the numbers from a double array together.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>A double containing the sum of the numbers in the array</strong></returns>
        /// </summary>

        public static double Sum(double[] x)
        {
            double sum = 0.0;
            int i = 0;

            foreach(int y in x)
            {
                sum = sum + x[i];
                i++;
            }
            return sum;
        }
    }
}
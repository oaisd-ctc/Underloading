namespace ArrayUtils
{
    public static class productivity
    {
        /// <summary>
        /// <c>Product</c> adds all numbers from an integer array together.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>An int containing the product </strong></returns>
        /// </summary>
        public static int Product(int[] x)
        {
            int ans = 1;
            int i = 0;

            foreach(int y in x)
            {
                ans = ans * x[i];
                i++;
            }
            return ans;
        }

        /// <summary>
        /// <c>Product</c> adds all numbers from a double array together.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>A double containing the product</strong></returns>
        /// </summary>
        public static double Product(double[] x)
        {
            double ans = 1.0;
            int i = 0;
            
            foreach(int y in  x)
            {
                ans = ans * x[i];
                i++;
            }
            return ans;
        }
    }
}
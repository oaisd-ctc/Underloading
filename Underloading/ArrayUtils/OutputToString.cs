namespace ArrayUtils
{
    public static class OutputToString
    {
        /// <summary>
        /// <c>ConvertToString</c> converts an integer array into a string, keeping the curly brackets.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>A string containing the contents of the integer array</strong></returns>
        /// </summary>
        public static string ConvertToString(int[] x)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (int item in x)
            {
                if (i < x.Length - 1)
                {
                    inputToString += $"{Convert.ToString(x.GetValue(i))}, ";
                }
                else
                {
                    inputToString += $"{Convert.ToString(x.GetValue(i))} }}";
                }
                i++;
            }

            return inputToString;
        }

        /// <summary>
        /// <c>ConvertToString</c> converts a double array into a string, keeping the curly brackets.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>A string containing the contents of the double array</strong></returns>
        /// </summary>
        public static string ConvertToString(double[] x)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (int item in x)
            {
                if (i < x.Length - 1)
                {
                    inputToString += $"{Convert.ToString(x.GetValue(i))}, ";
                }
                else
                {
                    inputToString += $"{Convert.ToString(x.GetValue(i))} }}";
                }
                i++;
            }
            return inputToString;
        }
    }
}
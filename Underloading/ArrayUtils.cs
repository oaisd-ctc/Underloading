namespace ArrayUtils
{
    public static class ArrayUtils
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



        /// <summary>
        /// <c>SortAscending</c> sorts an integer array in ascending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted integer array</strong></returns>
        /// </summary>
        public static string SortAscending(int[] x)
        {
            int t = 0;

            for (int i = 0; i <= x.Length - 1; i++)
            {
                for (int j = i+1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            string xString = OutputToString.ConvertToString(x);
            return xString;
        }

        /// <summary>
        /// <c>SortAscending</c> sorts a double array in ascending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted double array</strong></returns>
        /// </summary>
        public static string SortAscending(double[] x)
        {
            int t = 0;

            for (int i = 0; i <= x.Length - 1; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        t = (int) x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            string xString = OutputToString.ConvertToString(x);
            return xString;
        }



        /// <summary>
        /// <c>SortDescending</c> sorts an integer array in descending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted integer array</strong></returns>
        /// </summary>
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

        /// <summary>
        /// <c>SortDescending</c> sorts a double array in descending order.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>The sorted double array</strong></returns>
        /// </summary>
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



        /// <summary>
        /// <c>DupeArray</c> duplicates an array the amount of times the user specifies.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>A string containing the duped arrays</strong></returns>
        /// </summary>
        public static string Dupe(int[] x)
        {
            Console.Write("Enter how many times would you like to duplicate your array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int mult = (x.Length + 1) * num;

            int[] y = new int[x.Length];

            string fullString = "";

            int r = 0;
            for (int i = 0; i < mult; i++)
            {
                if (r < x.Length)
                {
                    y[r] = x[r];
                    r++;
                }
                else if (r == x.Length)
                {
                    r = 0;

                    int[] newerArr = y;
                    fullString += $"{OutputToString.ConvertToString(newerArr)}\n";
                }
            }

            return fullString;
        }
        
        /// <summary>
        /// <c>DupeArray</c> duplicates an array the amount of times the user specifies.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="number">
        /// <item><description><para><em>A double array</em></para></description></item>
        /// </list>
        /// <returns><strong>A string containing the duped arrays</strong></returns>
        /// </summary>
        public static string Dupe(double[] x)
        {
            Console.Write("Enter how many times would you like to duplicate your array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int mult = (x.Length + 1) * num;

            double[] y = new double[x.Length];

            string fullString = "";

            int r = 0;
            for (int i = 0; i < mult; i++)
            {
                if (r < x.Length)
                {
                    y[r] = x[r];
                    r++;
                }
                else if (r == x.Length)
                {
                    r = 0;

                    double[] newerArr = y;
                    fullString += $"{OutputToString.ConvertToString(newerArr)}\n";
                }
            }
            return fullString;
        } 
    }
}
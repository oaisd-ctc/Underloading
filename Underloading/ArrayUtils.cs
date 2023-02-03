namespace Underloading
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
        /// <param name="inputArr">
        /// The input array
        /// </param>
        public static double Average(int[] inputArr)
        {
            double ans = 0.0;
            int i = 0;

            foreach(int index in inputArr)
            { 
                ans += inputArr[i];
                i++;
            }
            return ans / inputArr.Length;
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
        /// <param name="inputArr">
        /// The input array
        /// </param>
        public static double Average(double[] inputArr)
        {
            double ans = 0.0;
            int i = 0;
            foreach(int index in inputArr)
            {
                ans += inputArr[i];
                i++;
            }
            return ans / inputArr.Length;
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
        /// <param name="inputArrX">
        /// The first input array
        /// </param>
        /// <param name="inputArrY">
        /// The second input array
        /// </param>
        public static int AddArray(int[] inputArrX, int[] inputArrY)
        {
            int added = 0;
            int added2 = 0;
            int i = 0;
            int r = 0;

            while (i < inputArrX.Length && r < inputArrY.Length)
            {
                if (i <= inputArrX.Length)
                {
                    added += inputArrX[i] +inputArrY[i];
                    i++;
                }
                else if (r <= inputArrY.Length)
                {
                    added2 += inputArrX[r] + inputArrY[r];
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
        /// <param name="inputArrX">
        /// The first input array
        /// </param>
        /// <param name="inputArrY">
        /// The second input array
        /// </param>
        public static double AddArray(double[] inputArrX, double[] inputArrY)
        {
            double added = 0;
            double added2 = 0;
            int i = 0;
            int r = 0;

            while (i <= inputArrX.Length - 1)
            {
                if(i <= inputArrX.Length && r < inputArrY.Length)
                {
                    added += inputArrX[i] + inputArrY[i];
                    i++;
                }
                else if (r <= inputArrY.Length)
                {
                    added2 += inputArrX[r] + inputArrY[r];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static int Product(int[] inputArr)
        {
            int ans = 1;
            int i = 0;

            foreach(int index in inputArr)
            {
                ans = ans * inputArr[i];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static double Product(double[] inputArr)
        {
            double ans = 1.0;
            int i = 0;
            foreach(int index in inputArr)
            {
                ans = ans * inputArr[i];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string SortAscending(int[] inputArr)
        {
            int t = 0;

            for (int i = 0; i <= inputArr.Length - 1; i++)
            {
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] > inputArr[j])
                    {
                        t = inputArr[i];
                        inputArr[i] = inputArr[j];
                        inputArr[j] = t;
                    }
                }
            }
            string xString = ConvertToString(inputArr);
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string SortAscending(double[] inputArr)
        {
            double t = 0;

            for (int i = 0; i <= inputArr.Length - 1; i++)
            {
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] > inputArr[j])
                    {
                        t = inputArr[i];
                        inputArr[i] = inputArr[j];
                        inputArr[j] = t;
                    }
                }
            }
            string xString = ConvertToString(inputArr);
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string SortDescending(int[] inputArr)
        {
            int t = 0;

            for (int i = 0; i <= inputArr.Length -1; i++)
            {
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] < inputArr[j])
                    {
                        t = inputArr[i];
                        inputArr[i] = inputArr[j];
                        inputArr[j] = t;
                    }
                }
            }
            string xString = ArrayToString(inputArr);
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string SortDescending(double[] inputArr)
        {
            double t = 0;

            for (int i = 0; i <= inputArr.Length -1; i++)
            {
                for (int j = i+1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] < inputArr[j])
                    {
                        t = inputArr[i];
                        inputArr[i] = inputArr[j];
                        inputArr[j] = t;
                    }
                }
            }
            string xString = ArrayToString(inputArr);
            return xString;
        }

        public static string ArrayToString(int[] inputArr)
        {
            string arrayToString = "{ ";
            int i = 0;

            foreach (int item in inputArr)
            {
                if (i < inputArr.Length - 1)
                {
                    arrayToString += $"{Convert.ToString(inputArr.GetValue(i))}, ";
                }
                else
                {
                    arrayToString += $"{Convert.ToString(inputArr.GetValue(i))} }}";
                }
                i++;
            }
            return arrayToString;
        }

        public static string ArrayToString(double[] inputArr)
        {
            string arrayToString = "{ ";
            int i = 0;

            foreach (int item in inputArr)
            {
                if (i < inputArr.Length - 1)
                {
                    arrayToString += $"{Convert.ToString(inputArr.GetValue(i))}, ";
                }
                else
                {
                    arrayToString += $"{Convert.ToString(inputArr.GetValue(i))} }}";
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static int SubArray(int[] inputArrX, int[] inputArrY)
        {
            double arraySub1 = Average(inputArrX);
            int subtracted = (int) arraySub1 * inputArrX.Length;

            double arraySub2 = Average(inputArrY);
            int subtracted2 = (int) arraySub2 * inputArrX.Length;

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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static double SubArray(double[] inputArrX, double[] inputArrY)
        {
            double arraySub1 = Average(inputArrX);
            double subtracted = arraySub1 * inputArrX.Length;

            double arraySub2 = Average(inputArrY);
            double subtracted2 = arraySub2 * inputArrX.Length;
            
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static int Sum(int[] inputArr)
        {
            int sum = 0;
            int i = 0;

            foreach(int inputArrY in inputArr)
            {
                sum = sum + inputArr[i];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>

        public static double Sum(double[] inputArr)
        {
            double sum = 0.0;
            int i = 0;

            foreach(int index in inputArr)
            {
                sum = sum + inputArr[i];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static int Max(int[] inputArr)
        {
            int max = inputArr[0];
            int i = 0;

            foreach(int index in inputArr)
            {
                if (inputArr[i] > max)
                {
                    max = inputArr[i];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static double Max(double[] inputArr)
        {
            double max = inputArr[0];
            int i = 0;

            foreach(int index in inputArr)
            {
                if (inputArr[i] > max)
                {
                    max = inputArr[i];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string ConvertToString(int[] inputArr)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (int item in inputArr)
            {
                if (i < inputArr.Length - 1)
                {
                    inputToString += $"{Convert.ToString(inputArr.GetValue(i))}, ";
                }
                else
                {
                    inputToString += $"{Convert.ToString(inputArr.GetValue(i))} }}";
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string ConvertToString(double[] inputArr)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (int item in inputArr)
            {
                if (i < inputArr.Length - 1)
                {
                    inputToString += $"{Convert.ToString(inputArr.GetValue(i))}, ";
                }
                else
                {
                    inputToString += $"{Convert.ToString(inputArr.GetValue(i))} }}";
                }
                i++;
            }
            return inputToString;
        }
        
        /// <summary>
        /// <c>ConvertToString</c> converts a string array into a string, keeping the curly brackets.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="string[]">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>A string containing the contents of the double array</strong></returns>
        /// </summary>
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string ConvertToString(string[] inputArr)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (string item in inputArr)
            {
                if (i < inputArr.Length - 1)
                {
                    inputToString += $"\"{Convert.ToString(inputArr.GetValue(i))}\", ";
                }
                else
                {
                    inputToString += $"\"{Convert.ToString(inputArr.GetValue(i))}\" }}";
                }
                i++;
            }
            return inputToString;
        }

        /// <summary>
        /// <c>ConvertToString</c> converts a character array into a string, keeping the curly brackets.
        /// <para>
        /// Requires:
        /// </para>
        /// <list type="char[]">
        /// <item><description><para><em>An integer array</em></para></description></item>
        /// </list>
        /// <returns><strong>A string containing the contents of the double array</strong></returns>
        /// </summary>
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static string ConvertToString(char[] inputArr)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (char item in inputArr)
            {
                if (i < inputArr.Length - 1)
                {
                    inputToString += $"'{Convert.ToString(inputArr.GetValue(i))}', ";
                }
                else
                {
                    inputToString += $"'{Convert.ToString(inputArr.GetValue(i))}' }}";
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static int Min(int[] inputArr)
        {
            int min = inputArr[0];
            int i = 0;

            foreach(int index in inputArr)
            {
                if (inputArr[i] < min)
                {
                    min = inputArr[i];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        public static double Min(double[] inputArr)
        {
            double min = inputArr[0];
            int i = 0;

            foreach(int index in inputArr)
            {
                if (inputArr[i] < min)
                {
                    min = inputArr[index];
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
        /// <param name="inputArr">
        /// The first input array
        /// </param>
        /// <param name="copies">
        /// The amount of copies to make
        /// </param>
        public static string Dupe(int[] inputArr, int copies)
        {
            int mult = (inputArr.Length + 1) * copies;

            int[] inputArrY = new int[inputArr.Length];
            string fullString = "";

            int r = 0;
            for (int i = 0; i < mult; i++)
            {
                if (r < inputArr.Length)
                {
                    inputArrY[r] = inputArr[r];
                    r++;
                }
                else if (r == inputArr.Length)
                {
                    r = 0;

                    int[] newerArr = inputArrY;
                    fullString += $"{ConvertToString(newerArr)}\n";
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
        /// <param name="inputArrX">
        /// The first input array
        /// </param>
        /// <param name="copies">
        /// The amount of copies to make
        /// </param>
        public static string Dupe(double[] inputArrX, int copies)
        {
            int mult = (inputArrX.Length + 1) * copies;

            double[] inputArrY = new double[inputArrX.Length];
            string fullString = "";

            int r = 0;
            for (int i = 0; i < mult; i++)
            {
                if (r < inputArrX.Length)
                {
                    inputArrY[r] = inputArrX[r];
                    r++;
                }
                else if (r == inputArrX.Length)
                {
                    r = 0;

                    double[] newerArr = inputArrY;
                    fullString += $"{ConvertToString(newerArr)}\n";
                }
            }
            return fullString;
        } 
    }
}
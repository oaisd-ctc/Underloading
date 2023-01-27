namespace ArrayUtils
{
    public static class thing
    {
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
    }
}
namespace ArrayUtils
{
    public static class OutputToString
    {
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

        public static string ConvertToString(string[] x)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (string item in x)
            {
                if (i < x.Length - 1)
                {
                    inputToString += $"\"{Convert.ToString(x.GetValue(i))}\", ";
                }
                else
                {
                    inputToString += $"\"{Convert.ToString(x.GetValue(i))}\" }}";
                }
                i++;
            }
            return inputToString;
        }

        public static string ConvertToString(char[] x)
        {
            string inputToString = "{ ";
            int i = 0;

            foreach (char item in x)
            {
                if (i < x.Length - 1)
                {
                    inputToString += $"'{Convert.ToString(x.GetValue(i))}', ";
                }
                else
                {
                    inputToString += $"'{Convert.ToString(x.GetValue(i))}' }}";
                }
                i++;
            }
            return inputToString;
        }
    }
}
namespace ArrayUtils
{
    public class addthemarrays
    {
        public static int AddArray(int[] x, int[] y)
        {
            int added = 0;
            int i = 0;

            while (i <= x.Length -1)
            {
                added = x[i] + y[i];
                i++;
            }
            return added;
        }

        public static double AddArray(double[] x, double[] y)
        {
            double added = 0;
            int i = 0;

            while (i <= x.Length -1)
            {
                added = x[i] + y[i];
                i++;
            }
            return added;
        }
    }
}
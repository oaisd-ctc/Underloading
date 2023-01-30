namespace ArrayUtils
{
    public static class submissiveArray
    {
        public static int Sub(int[] x, int[] y)
        {
            int subtracted = 0;
            int i = 0;

            while (i <= x.Length -1)
            {
                subtracted = x[i] - y[i];
                i++;
            }
            return subtracted;
        }

        public static double Sub(double[] x, double[] y)
        {
            double subtracted = 0;
            int i = 0;

            while (i <= x.Length -1)
            {
                subtracted = x[i] - y[i];
                i++;
            }
            return subtracted;
        }
    }
}
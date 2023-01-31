namespace ArrayUtils
{
    public static class submissiveArray
    {
        public static int Sub(int[] x, int[] y)
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

        public static double Sub(double[] x, double[] y)
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
    }
}
namespace ArrayUtils
{
    public static class macks
    {
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
    }
}
namespace ArrayUtils
{
    public static class summarizing
    {
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
    }
}
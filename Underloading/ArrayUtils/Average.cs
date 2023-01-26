namespace ArrayUtils
{
    public static class averaging
    {
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
    }
}
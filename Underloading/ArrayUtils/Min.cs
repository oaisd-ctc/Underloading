namespace ArrayUtils
{
    public static class minnie
    {
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
    }
}
namespace ArrayUtils
{
    public static class productivity
    {
        public static int Product(int[] x)
        {
            int ans = 1;
            int i = 0;

            foreach(int y in x)
            {
                ans = ans * x[i];
                i++;
            }
            return ans;
        }
    }
}
namespace ArrayUtils
{
    public class DupeArray
    {
        public static string Dupe(int[] x)
        {
            Console.Write("Enter how many times would you like to duplicate your array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int mult = (x.Length + 1) * num;

            int[] y = new int[x.Length];

            string fullString = "";

            int r = 0;
            for (int i = 0; i < mult; i++)
            {
                if (r < x.Length)
                {
                    y[r] = x[r];
                    r++;
                }
                else if (r == x.Length)
                {
                    r = 0;

                    int[] newerArr = y;
                    fullString += $"{OutputToString.ConvertToString(newerArr)}\n";
                }
            }

            return fullString;
        }
        
        public static string Dupe(double[] x)
        {
            Console.Write("Enter how many times would you like to duplicate your array: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int mult = (x.Length + 1) * num;

            double[] y = new double[x.Length];

            string fullString = "";

            int r = 0;
            for (int i = 0; i < mult; i++)
            {
                if (r < x.Length)
                {
                    y[r] = x[r];
                    r++;
                }
                else if (r == x.Length)
                {
                    r = 0;

                    double[] newerArr = y;
                    fullString += $"{OutputToString.ConvertToString(newerArr)}\n";
                }
            }
            return fullString;
        }
    }
}

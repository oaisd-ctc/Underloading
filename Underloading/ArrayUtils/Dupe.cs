namespace ArrayUtils
{
    public class duplicator
    {
        public static string Dupe(int[] x)
        {
            Console.WriteLine("How many times would you like to duplicate your array?");
            Console.WriteLine("(Note: If you enter 1, the array will make 1 copy.)");
            int num = Convert.ToInt32(Console.ReadLine());

            int mult = x.Length * num;

            int[] x2 = new int[x.Length];

            string h = $"{thing.ArrayToString(x)}\n";

            int r = 0;
            for (int i = 0; i < mult; i++)
            {
                if (r < x.Length)
                {
                    x2[r] = x[r];
                    r++;
                }
                else if (r == x.Length)
                {
                    r = 0;

                    int[] newerArr = x2;
                    h += $"{thing.ArrayToString(newerArr)}\n";
                }
            }

            return h;
        }
    }
}

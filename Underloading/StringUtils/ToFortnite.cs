namespace StringUtils
{
    public static class ToFortnite
    {
        public static string StringToWeLikeFortnite()
        {
            Console.Write("Enter any string to prove everyone likes fortnite: ");
            string fortnite = Console.ReadLine();
            string weLikeFortnite = "";

            int i = 0;

            foreach (char item in fortnite)
            {
                if (i < fortnite.Length - 1)
                {
                    weLikeFortnite += "we like fortnite, ";
                }
                else
                {
                    weLikeFortnite += "we like fortnite!";
                }

                i++;
            }

            return weLikeFortnite;
        }
    }
}
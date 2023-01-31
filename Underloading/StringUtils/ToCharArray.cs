namespace StringUtils
{
    public static class ToCharArray
    {
        public static char[] StringToCharArray()
        {
            Console.Write("Enter any string to convert to a char array: ");
            string userInput = Console.ReadLine();

            char[] output = new char[0];

            foreach (char item in userInput)
            {
                output = output.Append(item).ToArray();
            }

            return output;
        }
    }
}
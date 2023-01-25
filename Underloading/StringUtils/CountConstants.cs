namespace StringUtils
{
    public static class CountConstants
    {
        public static int NumberOfConstants()
        {
            Console.WriteLine("CountConstants");
            Console.Write("Input a string to see the number of constants in it: ");
            string input = UserInput();

            int i = 0;

            foreach (char letter in input)
            {
                char letterToLower = Convert.ToChar(letter.ToString().ToLower());
                if (letterToLower == 'b' || letterToLower == 'c' || letterToLower == 'd' || letterToLower == 'f' || letterToLower == 'g' || letterToLower == 'h' || letterToLower == 'j' || letterToLower == 'k' || letterToLower == 'l' || letterToLower == 'm' || letterToLower == 'n' || letterToLower == 'p' || letterToLower == 'q' || letterToLower == 'r' || letterToLower == 's' || letterToLower == 't' || letterToLower == 'v' || letterToLower == 'w' || letterToLower == 'x' || letterToLower == 'y' || letterToLower == 'z')
                {
                    i++;
                }
                else
                {
                    continue;
                }
            }

            return i;
        }

        public static string UserInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
namespace StringUtils
{
    public static class HasLetter
    {
        public static string IncludesLetter()
        {
            Console.WriteLine("HasLetter");
            Console.Write("Input a string to see the length it: ");
            string input = UserInput();

            Console.Write("Input a single character to search for the index and how many are (if any) are in the string: ");

            string letterInInput = "";
            string returnQuery = "";

            try
            {
                char letterSearch = UserInputChar();

                int i = 0;

                foreach (char letter in input)
                {
                    if (letter == letterSearch && i < input.Length)
                    {
                        letterInInput = "true";
                        i++;
                    }
                    else
                    {
                        i++;
                        continue;
                    }
                }

                returnQuery += $"Found in whole input: {letterInInput}";
            }
            catch (FormatException err)
            {
                Console.WriteLine("Try inputting a single character next time!", err);
            }

            return returnQuery;
        }

        public static string UserInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }

        public static char UserInputChar()
        {
            char userInput = Convert.ToChar(Console.ReadLine());

            return userInput;
        }
    }
}
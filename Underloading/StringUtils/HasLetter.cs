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
            string letterFound = "{ ";
            string returnQuery = "";
            char prevLetter = '℗';

            try
            {
                char letterSearch = UserInputChar();

                int i = 0;

                foreach (char letter in input)
                {
                    if ((i < input.Length) && (i != (input.Length - 1)))
                    {
                        if (((letter == letterSearch) && (i == 0)) || ((prevLetter != letterSearch) && (letter == letterSearch) && (i - 1 == 0)))
                        {
                            letterFound += $"{i}";

                            letterInInput = "true";
                        }
                        else if ((((prevLetter == letterSearch) && (letter == letterSearch)) || ((prevLetter == letterSearch) && (letter == letterSearch)) || ((prevLetter != letterSearch) && (letter == letterSearch))) && (i > 0))
                        {
                            letterFound += $", {i}";

                            letterInInput = "true";
                        }
                    }
                    else if (i == (input.Length - 1))
                    {
                        if ((letter == letterSearch && i == 0) || ((prevLetter != letterSearch) && (letter == letterSearch && i > 0)))
                        {
                            letterFound += $"{i}";

                            letterInInput = "true";
                        }
                        else if ((prevLetter == letterSearch) && (letter == letterSearch))
                        {
                            letterFound += $", {i}";

                            letterInInput = "true";
                        }
                        else if ((letter == letterSearch) && (prevLetter == letterSearch))
                        {
                            letterFound += $"{i}";
                        }
                        else if ((letter != letterSearch) && (prevLetter != letterSearch))
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (letter == letterSearch)
                        {
                            letterFound += $", {i} }}";
                        }
                        else if (letter != letterSearch && letterFound.Length == 2)
                        {
                            letterFound += "-1 }";

                            letterInInput = "false";
                        }
                        else if (letter != letterSearch && letterFound.Length > 2)
                        {
                            letterFound += " }";
                        }
                    }

                    i++;
                }

                returnQuery += $"{{ Found in whole input: {letterInInput}, Found in indices: {letterFound} }} }}";
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
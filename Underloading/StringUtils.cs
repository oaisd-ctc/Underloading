namespace Underloading
{
    public static class StringUtils
    {
        /**
         * <summary>
         * Converts a string to all uppercasing
         * </summary>
         * <param name="input">
         * The string to convert to all uppercasing
         * </param>
         * <returns>
         * The input to all uppercasing
         * </returns>
         */

        public static string ToUpper(string input)
        {
            char[] letterArr = new char[input.Length];

            char[] cloneArr = new char[input.Length];
            Array.Copy(letterArr, cloneArr, input.Length);

            int i = 0;

            string yelledWord = "";
            foreach (char letter in input)
            {
                char character = letter;

                if (character == 'a')
                {
                    character = 'A';
                    yelledWord += character;
                }
                else if (character == 'b')
                {
                    character = 'B';
                    yelledWord += character;
                }
                else if (character == 'c')
                {
                    character = 'C';
                    yelledWord += character;
                }
                else if (character == 'd')
                {
                    character = 'D';
                    yelledWord += character;
                }
                else if (character == 'e')
                {
                    character = 'E';
                    yelledWord += character;
                }
                else if (character == 'f')
                {
                    character = 'F';
                    yelledWord += character;
                }
                else if (character == 'g')
                {
                    character = 'G';
                    yelledWord += character;
                }
                else if (character == 'h')
                {
                    character = 'H';
                    yelledWord += character;
                }
                else if (character == 'i')
                {
                    character = 'I';
                    yelledWord += character;
                }
                else if (character == 'j')
                {
                    character = 'J';
                    yelledWord += character;
                }
                else if (character == 'k')
                {
                    character = 'K';
                    yelledWord += character;
                }
                else if (character == 'l')
                {
                    character = 'L';
                    yelledWord += character;
                }
                else if (character == 'm')
                {
                    character = 'M';
                    yelledWord += character;
                }
                else if (character == 'n')
                {
                    character = 'N';
                    yelledWord += character;
                }
                else if (character == 'o')
                {
                    character = 'O';
                    yelledWord += character;
                }
                else if (character == 'p')
                {
                    character = 'P';
                    yelledWord += character;
                }
                else if (character == 'q')
                {
                    character = 'Q';
                    yelledWord += character;
                }
                else if (character == 'r')
                {
                    character = 'R';
                    yelledWord += character;
                }
                else if (character == 's')
                {
                    character = 'S';
                    yelledWord += character;
                }
                else if (character == 't')
                {
                    character = 'T';
                    yelledWord += character;
                }
                else if (character == 'u')
                {
                    character = 'U';
                    yelledWord += character;
                }
                else if (character == 'v')
                {
                    character = 'V';
                    yelledWord += character;
                }
                else if (character == 'w')
                {
                    character = 'W';
                    yelledWord += character;
                }
                else if (character == 'x')
                {
                    character = 'X';
                    yelledWord += character;
                }
                else if (character == 'y')
                {
                    character = 'Y';
                    yelledWord += character;
                }
                else if (character == 'z')
                {
                    character = 'Z';
                    yelledWord += character;
                }
                else
                {
                    yelledWord += character;
                }

                i++;
            }

            return yelledWord;
        }

        /**
         * <summary>
         * Converts a string to all lowercasing
         * </summary>
         * <param name="input">
         * The string to convert to all lowercasing
         * </param>
         * <returns>
         * The input to all lowercasing
         * </returns>
         */
        public static string ToLower(string input)
        {
            int i = 0;

            string whisperedWord = "";
            foreach (char letter in input)
            {
                char character = letter;

                if (character == 'A')
                {
                    character = 'a';
                    whisperedWord += character;
                }
                else if (character == 'B')
                {
                    character = 'b';
                    whisperedWord += character;
                }
                else if (character == 'C')
                {
                    character = 'c';
                    whisperedWord += character;
                }
                else if (character == 'D')
                {
                    character = 'd';
                    whisperedWord += character;
                }
                else if (character == 'E')
                {
                    character = 'e';
                    whisperedWord += character;
                }
                else if (character == 'F')
                {
                    character = 'f';
                    whisperedWord += character;
                }
                else if (character == 'G')
                {
                    character = 'g';
                    whisperedWord += character;
                }
                else if (character == 'H')
                {
                    character = 'h';
                    whisperedWord += character;
                }
                else if (character == 'I')
                {
                    character = 'i';
                    whisperedWord += character;
                }
                else if (character == 'J')
                {
                    character = 'j';
                    whisperedWord += character;
                }
                else if (character == 'K')
                {
                    character = 'k';
                    whisperedWord += character;
                }
                else if (character == 'L')
                {
                    character = 'l';
                    whisperedWord += character;
                }
                else if (character == 'M')
                {
                    character = 'm';
                    whisperedWord += character;
                }
                else if (character == 'N')
                {
                    character = 'n';
                    whisperedWord += character;
                }
                else if (character == 'O')
                {
                    character = 'o';
                    whisperedWord += character;
                }
                else if (character == 'P')
                {
                    character = 'p';
                    whisperedWord += character;
                }
                else if (character == 'Q')
                {
                    character = 'q';
                    whisperedWord += character;
                }
                else if (character == 'R')
                {
                    character = 'r';
                    whisperedWord += character;
                }
                else if (character == 'S')
                {
                    character = 's';
                    whisperedWord += character;
                }
                else if (character == 'T')
                {
                    character = 't';
                    whisperedWord += character;
                }
                else if (character == 'U')
                {
                    character = 'u';
                    whisperedWord += character;
                }
                else if (character == 'V')
                {
                    character = 'v';
                    whisperedWord += character;
                }
                else if (character == 'W')
                {
                    character = 'w';
                    whisperedWord += character;
                }
                else if (character == 'X')
                {
                    character = 'x';
                    whisperedWord += character;
                }
                else if (character == 'Y')
                {
                    character = 'y';
                    whisperedWord += character;
                }
                else if (character == 'Z')
                {
                    character = 'z';
                    whisperedWord += character;
                }
                else
                {
                    whisperedWord += character;
                }

                i++;
            }

            return whisperedWord;
        }

        /**
         * <summary>
         * Finds the length of the string
         * </summary>
         * <param name="input">
         * The string to find the length of
         * </param>
         * <returns>
         * The length of the input
         * </returns>
         */
        public static int Length(string input)
        {
            int i = 0;

            foreach (char letter in input)
            {
                i++;
            }

            return i;
        }

        /**
         * <summary>
         * Reverses the order of the characters in a string
         * </summary>
         * <param name="input">
         * The string to reverse
         * </param>
         * <returns>
         * The input, reversed
         * </returns>
         */
        public static string Reverse(string input)
        {
            string reversedString = String.Empty;

            for (int i = input.Length - 1; i > -1;  i--)
            {
                char[] charArrayOfInput = ToCharArray(input);

                string? letter = charArrayOfInput.GetValue(i).ToString();
                reversedString += letter;
            }

            return reversedString;
        }

        /**
         * <summary>
         * Counts all vowels in a string
         * </summary>
         * <param name="input">
         * The string to count the vowels in
         * </param>
         * <returns>
         * The number of vowels in the input
         * </returns>
         */
        public static int CountVowels(string input)
        {
            int i = 0;

            foreach (char letter in input)
            {
                char letterToLower = Convert.ToChar(letter.ToString().ToLower());
                if (letterToLower == 'a' || letterToLower == 'e' || letterToLower == 'i' || letterToLower == 'o' || letterToLower == 'u')
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

        /**
         * <summary>
         * Counts all the consonants in a string
         * </summary>
         * <param name="input">
         * The string to count the consonants in
         * </param>
         * <returns>
         * The number of consonants in the given string
         * </returns>
         */
        public static int CountConsonants(string input)
        {
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

        /**
         * <summary>
         * Searches for a character in a given string
         * </summary>
         * <param name="input">
         * The string to search for the letter
         * </param>
         * <param name="letter">
         * </param>
         * The character to search for in the input
         * <returns>
         * A boolean regarding the facts behind the search
         * </returns>
         */
        public static bool HasLetter(string input, char letterSearch)
        {
            bool letterInInput = false;
            bool returnQuery = false;

            int i = 0;

            foreach (char letter in input)
            {
                if (letter == letterSearch && i < input.Length)
                {
                    letterInInput = true;
                    i++;
                }
                else
                {
                    i++;
                    continue;
                }
            }

            returnQuery = letterInInput;
            return returnQuery;
        }

        /**
         * <summary>
         * Converts a string to a character array
         * </summary>
         * <param name="input">
         * The string to convert to a character array
         * </param>
         * <returns>
         * A character array with a character for each character in the input
         * </returns>
         */
        public static char[] ToCharArray(string input)
        {
            char[] output = new char[0];

            foreach (char item in input)
            {
                output = output.Append(item).ToArray();
            }

            return output;
        }

        /**
         * <summary>
         * Outputs the input to a file called "../output.txt"
         * </summary>
         * <param name="input">
         * The string to output to the file
         * </param>
         * <returns>
         * The contents of the newly created file
         * </returns>
         */
        public static string ToFile(string input)
        {
            FileStream outputFile = File.Create("../output.txt");
            outputFile.Close();
            File.WriteAllText("../output.txt", input);

            return File.ReadAllText("../output.txt");
        }

        /**
         * <summary>
         * Converts each character in a given string to "we like fortnite", can create console-flooding
         * </summary>
         * <param name="input">
         * The string to spam "we like fortnite" to the console with
         * </param>
         * <returns>
         * The string of all the "we like fortnite" phrases glued together in a grammatically-ish correct way...
         * </returns>
         */
        public static string ToFortnite(string input)
        {
            string weLikeFortnite = "";

            int i = 0;

            foreach (char item in input)
            {
                if (i < input.Length - 1)
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

        /**
         * <summary>
         * Converts three inputs to a very basic and simple HTML page markup
         * </summary>
         * <param name="title">
         * The title of the webpage (goes in the head element, not visible on the final actual website)
         * </param>
         * <param name="hOne">
         * The header of the webpage (goes in the body element, is visible on the final actual website)
         * </param>
         * <param name="p">
         * The paragraph of the webpage (goes in the body element, is visible on the final actual website)
         * </param>
         * <returns>
         * A basic HTML markup structure as a ridiculous string, in regards to it's formatting
         * </returns>
         */
        public static string ToHTML(string title, string hOne, string p)
        {
            string HTMLString = $"<!DOCTYPE html>\n<html lang=\"en-US\">\n\t<head>\n\t\t<title>{title}</title>\n\t</head>\n\n\t<body>\n\t\t<h1>{hOne}</h1>\n\n\t\t<p>{p}</p>\n\t</body>\n</html>";

            return HTMLString;
        }

        /**
         * <summary>
         * Gathers the user input in a single character
         * </summary>
         * <returns>
         * The user input as a character
         * </returns>
         */
        public static char UserInputChar()
        {
            char userInput = Convert.ToChar(Console.ReadLine());

            return userInput;
        }

        /**
         * <summary>
         * Gathers the user input in a string
         * </summary>
         * <returns>
         * The user input as a string
         * </returns>
         */
        public static string UserInput()
        {
            string? userInput = Console.ReadLine();

            return userInput;
        }
    }
}

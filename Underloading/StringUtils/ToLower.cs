namespace StringUtils
{
    public static class ToLower
    {
        public static string Whisper()
        {
            Console.WriteLine("ToLower");
            Console.Write("Input a string to see it in all lowercase: ");
            string input = UserInput();

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

        public static string UserInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
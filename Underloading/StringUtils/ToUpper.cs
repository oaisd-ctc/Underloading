namespace StringUtils
{
    public static class ToUpper
    {
        public static string Yell()
        {
            Console.WriteLine("ToUpper");
            Console.Write("Input a string to see it in all uppercase: ");
            string input = UserInput();

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

        public static string UserInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
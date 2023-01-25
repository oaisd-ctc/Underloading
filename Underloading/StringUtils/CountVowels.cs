namespace StringUtils
{
    public static class CountVowels
    {
        public static int NumberOfVowels()
        {
            Console.WriteLine("CountVowels");
            Console.Write("Input a string to see the number of vowels in it: ");
            string input = UserInput();

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

        public static string UserInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
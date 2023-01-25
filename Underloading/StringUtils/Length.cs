namespace StringUtils {
    public static class Length {
        public static int HowLong()
        {
            Console.WriteLine("Length");
            Console.Write("Input a string to see the length of it: ");
            string input = UserInput();

            int i = 0;

            foreach (char letter in input)
            {
                i++;
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
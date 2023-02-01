using Underloading;
using ArrayUtils;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ToUpper");
        Console.Write("Input a string to see it in all uppercase: ");
        string inputToUpper = StringUtils.UserInput();
        Console.WriteLine(StringUtils.ToUpper(inputToUpper));

        Console.WriteLine("-----------------------");

        Console.WriteLine("ToLower");
        Console.Write("Input a string to see it in all lowercase: ");
        string inputToLower = StringUtils.UserInput();
        Console.WriteLine(StringUtils.ToLower(inputToLower));

        Console.WriteLine("-----------------------");

        Console.WriteLine("Length");
        Console.Write("Input a string to see the length of it: ");
        string inputLength = StringUtils.UserInput();
        Console.WriteLine(StringUtils.Length(inputLength));

        Console.WriteLine("-----------------------");

        Console.WriteLine("Reverse");
        Console.Write("Input a string to see it reversed: ");
        string inputToReverse = StringUtils.UserInput();
        Console.WriteLine(StringUtils.Reverse(inputToReverse));

        Console.WriteLine("-----------------------");

        Console.WriteLine("CountVowels");
        Console.Write("Input a string to see the number of vowels in it: ");
        string inputCountVowels = StringUtils.UserInput();
        Console.WriteLine(StringUtils.CountVowels(inputCountVowels));

        Console.WriteLine("-----------------------");

        Console.WriteLine("CountConstants");
        Console.Write("Input a string to see the number of constants in it: ");
        string inputCountConstants = StringUtils.UserInput();
        Console.WriteLine(StringUtils.CountConstants(inputCountConstants));

        Console.WriteLine("-----------------------");

        Console.WriteLine("HasLetter");
        Console.Write("Input a string to see if the a letter is there: ");
        string inputHasLetter = StringUtils.UserInput();
        Console.Write("Input a single character to search for the index and how many are (if any) are in the string: ");
        try
        {
            char letterSearch = StringUtils.UserInputChar();
            Console.WriteLine(StringUtils.HasLetter(inputHasLetter, letterSearch));
        }
        catch (FormatException err)
        {
            Console.WriteLine("Try inputting a single character next time!", err);
        }

        Console.WriteLine("-----------------------");

        Console.WriteLine("ToCharArray");
        Console.Write("Enter any string to convert to a char array: ");
        string inputToCharArray = StringUtils.UserInput();
        Console.WriteLine(OutputToString.ConvertToString(StringUtils.ToCharArray(inputToCharArray)));

        Console.WriteLine("-----------------------");

        Console.WriteLine("ToFile");
        Console.Write("Enter any string to paste into a new file: ");
        string inputToFile = StringUtils.UserInput();
        StringUtils.ToFile(inputToFile);
        Console.WriteLine("Note: Check the newly created \"output.txt\" file for the output of this method.");

        Console.WriteLine("-----------------------");

        Console.WriteLine("ToFortnite");
        Console.Write("Enter any string to prove everyone likes fortnite: ");
        string fortnite = StringUtils.UserInput();
        Console.WriteLine(StringUtils.ToFortnite(fortnite));

        Console.WriteLine("-----------------------");

        Console.WriteLine("ToHTML");
        Console.Write("Add a tab name to your website: ");
        string title = StringUtils.UserInput();
        Console.Write("Add a header to your webpage page: ");
        string hOne = StringUtils.UserInput();
        Console.Write("Add a paragraph about the title to your webpage: ");
        string p = StringUtils.UserInput();
        Console.WriteLine(StringUtils.ToHTML(title, hOne, p));
    }
}
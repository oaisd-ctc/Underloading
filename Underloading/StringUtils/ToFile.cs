namespace StringUtils
{
    public static class ToFile
    {
        public static void PasteToFile()
        {
            Console.Write("Enter any string to paste into a new file: ");
            string userInputContents = Console.ReadLine();

            FileStream outputFile = File.Create("../output.txt");
            outputFile.Close();
            File.WriteAllText("../output.txt", userInputContents);
        }
    }
}
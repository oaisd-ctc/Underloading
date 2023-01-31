namespace StringUtils
{
    public static class ToHTML
    {
        public static string StringToHTML()
        {
            string[] head = new string[1];
            string[] body = new string[2];

            Console.Write("Add a tab name to your website: ");
            string title = Console.ReadLine();

            Console.Write("Add a header to your webpage page: ");
            string hOne = Console.ReadLine();

            Console.Write("Add a paragraph about the title to your webpage: ");
            string p = Console.ReadLine();

            head.Append(title);
            body.Append(hOne);
            body.Append(p);

            string HTMLString = $"<!DOCTYPE html>\n<html lang=\"en-US\">\n\t<head>\n\t\t<title>{title}</title>\n\t</head>\n\n\t<body>\n\t\t<h1>{hOne}</h1>\n\n\t\t<p>{p}</p>\n\t</body>\n</html>";

            return HTMLString;
        }
    }
}
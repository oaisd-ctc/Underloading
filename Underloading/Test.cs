using Xunit;
using Underloading;

public class Test
{
    [Fact]
    public void test_number_of_consonants()
    {
        int desiredOutcome = 24; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z has 24 consonants
        Assert.Equal(desiredOutcome, StringUtils.CountConsonants("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_number_of_vowels()
    {
        int desiredOutcome = 5; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z has 5 vowels
        Assert.Equal(desiredOutcome, StringUtils.CountVowels("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_has_letter()
    {
        bool desiredOutcome = true; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z has the character h
        Assert.Equal(desiredOutcome, StringUtils.HasLetter("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z", 'h'));
    }

    [Fact]
    public void test_length()
    {
        int desiredOutcome = 42; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z has 42 characters
        Assert.Equal(desiredOutcome, StringUtils.Length("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_reverse()
    {
        string desiredOutcome = "z3JQ4pD1EO1if0T157v8ewv2jWVPpR3h5JO4VvQLZq"; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z reversed is z3JQ4pD1EO1if0T157v8ewv2jWVPpR3h5JO4VvQLZq
        Assert.Equal(desiredOutcome, StringUtils.Reverse("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_to_lower()
    {
        string desiredOutcome = "qzlqvv4oj5h3rppvwj2vwe8v751t0fi1oe1dp4qj3z"; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z to lower is, qzlqvv4oj5h3rppvwj2vwe8v751t0fi1oe1dp4qj3z
        Assert.Equal(desiredOutcome, StringUtils.ToLower("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_to_upper()
    {
        string desiredOutcome = "QZLQVV4OJ5H3RPPVWJ2VWE8V751T0FI1OE1DP4QJ3Z"; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z to upper is, QZLQVV4OJ5H3RPPVWJ2VWE8V751T0FI1OE1DP4QJ3Z
        Assert.Equal(desiredOutcome, StringUtils.ToUpper("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_to_char_array()
    {
        char[] desiredOutcome = { 'q', 'Z', 'L', 'Q', 'v', 'V', '4', 'O', 'J', '5', 'h', '3', 'R', 'p', 'P', 'V', 'W', 'j', '2', 'v', 'w', 'e', '8', 'v', '7', '5', '1', 'T', '0', 'f', 'i', '1', 'O', 'E', '1', 'D', 'p', '4', 'Q', 'J', '3', 'z' }; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z to a character array is, { 'q', 'Z', 'L', 'Q', 'v', 'V', '4', 'O', 'J', '5', 'h', '3', 'R', 'p', 'P', 'V', 'W', 'j', '2', 'v', 'w', 'e', '8', 'v', '7', '5', '1', 'T', '0', 'f', 'i', '1', 'O', 'E', '1', 'D', 'p', '4', 'Q', 'J', '3', 'z' }
        Assert.Equal(desiredOutcome, StringUtils.ToCharArray("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_to_file()
    {
        StringUtils.ToFile("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z");
        string desiredOutcome = File.ReadAllText("../output.txt");
        Assert.Equal(desiredOutcome, StringUtils.ToFile("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z")); // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z
    }

    [Fact]
    public void test_to_fortnite()
    {
        string desiredOutcome = "we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite!"; // qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z to Fortnite is, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite, we like fortnite!
        Assert.Equal(desiredOutcome, StringUtils.ToFortnite("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }

    [Fact]
    public void test_to_HTML()
    {
        string desiredOutcome = "<!DOCTYPE html>\n<html lang=\"en-US\">\n\t<head>\n\t\t<title>qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z</title>\n\t</head>\n\n\t<body>\n\t\t<h1>qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z</h1>\n\n\t\t<p>qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z</p>\n\t</body>\n</html>"; // (wLKXLKrrxQzGsKZKayXeLmMvKyMdLQRxATaWierRNp, wLKXLKrrxQzGsKZKayXeLmMvKyMdLQRxATaWierRNp, wLKXLKrrxQzGsKZKayXeLmMvKyMdLQRxATaWierRNp) to HTML is, <!DOCTYPE html>\n<html lang=\"en-US\">\n\t<head>\n\t\t<title>wLKXLKrrxQzGsKZKayXeLmMvKyMdLQRxATaWierRNp</title>\n\t</head>\n\n\t<body>\n\t\t<h1>wLKXLKrrxQzGsKZKayXeLmMvKyMdLQRxATaWierRNp</h1>\n\n\t\t<p>wLKXLKrrxQzGsKZKayXeLmMvKyMdLQRxATaWierRNp</p>\n\t</body>\n</html>
        Assert.Equal(desiredOutcome, StringUtils.ToHTML("qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z", "qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z", "qZLQvV4OJ5h3RpPVWj2vwe8v751T0fi1OE1Dp4QJ3z"));
    }
}
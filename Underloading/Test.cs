using Xunit;
using Underloading;

public class Test
{
    // If something is commented out, then it passed

    [Fact]
    public void test_add_array_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};
        int[] testArray2 = {2, 5, 19, 8, 10, 54};
        int desiredOutcome = 190;

        Assert.Equal(desiredOutcome, ArrayUtils.AddArray(testArray1, testArray2));
    }
    [Fact]
    public void test_add_array_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};
        double[] testArray2 = {2.2, 5.5, 19.19, 8.8, 10.10, 54.54};
        double desiredOutcome = 195.14;

        Assert.Equal(desiredOutcome, ArrayUtils.AddArray(testArray1, testArray2));
    }

    [Fact]
    public void test_sub_array_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};
        int[] testArray2 = {2, 5, 19, 8, 10, 54};
        int desiredOutcome = -6;

        Assert.Equal(desiredOutcome, ArrayUtils.SubArray(testArray1, testArray2));
    }

    [Fact]
    public void test_sub_array_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53}; // 94.81 | 15.801666
        double[] testArray2 = {2.2, 5.5, 19.19, 8.8, 10.10, 54.54}; // 100.33 | 16.721666
        double desiredOutcome = -5.5200000000000102;

        Assert.Equal(desiredOutcome, ArrayUtils.SubArray(testArray1, testArray2));
    }

    [Fact]
    public void test_average_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};

        double desiredOutcome = 15.333333333333334;

        Assert.Equal(desiredOutcome, ArrayUtils.Average(testArray1));
    }

    [Fact]
    public void test_average_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        double desiredOutcome = 15.801666666666668;

        Assert.Equal(desiredOutcome, ArrayUtils.Average(testArray1));
    }

    [Fact]
    public void test_dupeArray_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};
        int copies = 2;

        string desiredOutcome = "{ 1, 4, 18, 7, 9, 53 }\n{ 1, 4, 18, 7, 9, 53 }\n";

        Assert.Equal(desiredOutcome, ArrayUtils.Dupe(testArray1, copies));
    }

    [Fact]
    public void test_dupeArray_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};
        int copies = 2;

        string desiredOutcome = "{ 1.1, 4.4, 18.18, 7.7, 9.9, 53.53 }\n{ 1.1, 4.4, 18.18, 7.7, 9.9, 53.53 }\n";

        Assert.Equal(desiredOutcome, ArrayUtils.Dupe(testArray1, copies));
    }

    [Fact]
    public void test_max_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};

        int desiredOutcome = 53;

        Assert.Equal(desiredOutcome, ArrayUtils.Max(testArray1));
    }

    [Fact]
    public void test_max_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        double desiredOutcome = 53.53;

        Assert.Equal(desiredOutcome, ArrayUtils.Max(testArray1));
    }

    [Fact]
    public void test_min_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};

        int desiredOutcome = 1;

        Assert.Equal(desiredOutcome, ArrayUtils.Min(testArray1));
    }

    [Fact]
    public void test_min_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        double desiredOutcome = 1.1;

        Assert.Equal(desiredOutcome, ArrayUtils.Min(testArray1));
    }

    [Fact]
    public void test_toString_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};
        
        string desiredOutcome = "{ 1, 4, 18, 7, 9, 53 }";

        Assert.Equal(desiredOutcome, ArrayUtils.ConvertToString(testArray1));
    }

    [Fact]
    public void test_toString_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        string desiredOutcome = "{ 1.1, 4.4, 18.18, 7.7, 9.9, 53.53 }";

        Assert.Equal(desiredOutcome, ArrayUtils.ConvertToString(testArray1));
    }

    [Fact]
    public void test_product_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};

        int desiredOutcome = 240408;

        Assert.Equal(desiredOutcome, ArrayUtils.Product(testArray1));
    }

    [Fact]
    public void test_product_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        double desiredOutcome = 359056.1779912801;

        Assert.Equal(desiredOutcome, ArrayUtils.Product(testArray1));
    }

    [Fact]
    public void test_sort_ascending_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};

        string desiredOutcome = "{ 1, 4, 7, 9, 18, 53 }";

        Assert.Equal(desiredOutcome, ArrayUtils.SortAscending(testArray1));
    }

    [Fact]
    public void test_sort_ascending_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        string desiredOutcome = "{ 1.1, 4.4, 7.7, 9.9, 18.18, 53.53 }";

        Assert.Equal(desiredOutcome, ArrayUtils.SortAscending(testArray1));
    }

    [Fact]
    public void test_sort_descending_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};

        string desiredOutcome = "{ 53, 18, 9, 7, 4, 1 }";

        Assert.Equal(desiredOutcome, ArrayUtils.SortDescending(testArray1));
    }

    [Fact]
    public void test_sort_descending_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        string desiredOutcome = "{ 53.53, 18.18, 9.9, 7.7, 4.4, 1.1 }";

        Assert.Equal(desiredOutcome, ArrayUtils.SortDescending(testArray1));
    }

    [Fact]
    public void test_sum_with_ints()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};

        int desiredOutcome = 92;

        Assert.Equal(desiredOutcome, ArrayUtils.Sum(testArray1));
    }

    [Fact]
    public void test_sum_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        double desiredOutcome = 94.81;

        Assert.Equal(desiredOutcome, ArrayUtils.Sum(testArray1));
    }

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
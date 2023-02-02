using Xunit;
using Underloading;

public class Tests
{
    // If something is commented out, then it passed

    // [Fact]
    // public void test_add_array_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};
    //     int[] testArray2 = {2, 5, 19, 8, 10, 54};
    //     int desiredOutcome = 190;

    //     Assert.Equal(desiredOutcome, ArrayUtils.AddArray(testArray1, testArray2));
    // }
    [Fact]
    public void test_add_array_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};
        double[] testArray2 = {2.2, 5.5, 19.19, 8.8, 10.10, 54.54};
        double desiredOutcome = 195.14;

        Assert.Equal(desiredOutcome, ArrayUtils.AddArray(testArray1, testArray2));
    }



    // [Fact]
    // public void test_sub_array_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};
    //     int[] testArray2 = {2, 5, 19, 8, 10, 54};
    //     int desiredOutcome = -6;

    //     Assert.Equal(desiredOutcome, ArrayUtils.SubArray(testArray1, testArray2));
    // }
    // [Fact]
    // public void test_sub_array_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53}; // 94.81 | 15.801666
    //     double[] testArray2 = {2.2, 5.5, 19.19, 8.8, 10.10, 54.54}; // 100.33 | 16.721666
    //     double desiredOutcome = -5.5200000000000102;

    //     Assert.Equal(desiredOutcome, ArrayUtils.SubArray(testArray1, testArray2));
    // }



    // [Fact]
    // public void test_average_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     double desiredOutcome = 15.333333333333334;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Average(testArray1));
    // }
    // [Fact]
    // public void test_average_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

    //     double desiredOutcome = 15.801666666666668;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Average(testArray1));
    // }



    // [Fact]
    // public void test_dupeArray_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     string desiredOutcome = "{ 1, 4, 18, 7, 9, 53 }\n{ 1, 4, 18, 7, 9, 53 }\n";

    //     Assert.Equal(desiredOutcome, ArrayUtils.Dupe(testArray1));
    // }
    // [Fact]
    // public void test_dupeArray_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

    //     string desiredOutcome = "{ 1.1, 4.4, 18.18, 7.7, 9.9, 53.53 }\n{ 1.1, 4.4, 18.18, 7.7, 9.9, 53.53 }\n";

    //     Assert.Equal(desiredOutcome, ArrayUtils.Dupe(testArray1));
    // }



    // [Fact]
    // public void test_max_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     int desiredOutcome = 53;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Max(testArray1));
    // }
    // [Fact]
    // public void test_max_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

    //     double desiredOutcome = 53.53;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Max(testArray1));
    // }



    // [Fact]
    // public void test_min_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     int desiredOutcome = 1;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Min(testArray1));
    // }
    // [Fact]
    // public void test_min_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

    //     double desiredOutcome = 1.1;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Min(testArray1));
    // }



    // [Fact]
    // public void test_toString_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};
        
    //     string desiredOutcome = "{ 1, 4, 18, 7, 9, 53 }";

    //     Assert.Equal(desiredOutcome, ArrayUtils.ConvertToString(testArray1));
    // }
    // [Fact]
    // public void test_toString_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

    //     string desiredOutcome = "{ 1.1, 4.4, 18.18, 7.7, 9.9, 53.53 }";

    //     Assert.Equal(desiredOutcome, ArrayUtils.ConvertToString(testArray1));
    // }



    // [Fact]
    // public void test_product_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     int desiredOutcome = 240408;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Product(testArray1));
    // }
    // [Fact]
    // public void test_product_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

    //     double desiredOutcome = 359056.1779912801;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Product(testArray1));
    // }



    // [Fact]
    // public void test_sort_ascending_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     string desiredOutcome = "{ 1, 4, 7, 9, 18, 53 }";

    //     Assert.Equal(desiredOutcome, ArrayUtils.SortAscending(testArray1));
    // }
    [Fact]
    public void test_sort_ascending_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        string desiredOutcome = "{ 1.1, 4.4, 7.7, 9.9, 18.18, 53.53 }";

        Assert.Equal(desiredOutcome, ArrayUtils.SortAscending(testArray1));
    }



    // [Fact]
    // public void test_sort_descending_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     string desiredOutcome = "{ 53, 18, 9, 7, 4, 1 }";

    //     Assert.Equal(desiredOutcome, ArrayUtils.SortDescending(testArray1));
    // }
    [Fact]
    public void test_sort_descending_with_doubles()
    {
        double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

        string desiredOutcome = "{ 53.53, 18.18, 9.9, 7.7, 4.4, 1.1 }";

        Assert.Equal(desiredOutcome, ArrayUtils.SortDescending(testArray1));
    }



    // [Fact]
    // public void test_sum_with_ints()
    // {
    //     int[] testArray1 = {1, 4, 18, 7, 9, 53};

    //     int desiredOutcome = 92;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Sum(testArray1));
    // }
    // [Fact]
    // public void test_sum_with_doubles()
    // {
    //     double[] testArray1 = {1.1, 4.4, 18.18, 7.7, 9.9, 53.53};

    //     double desiredOutcome = 94.81;

    //     Assert.Equal(desiredOutcome, ArrayUtils.Sum(testArray1));
    // }
}
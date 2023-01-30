using Xunit;

public class Tests
{
    [Fact]
    public void test_add_array()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};
        int[] testArray2 = {2, 5, 19, 8, 10, 54};
        int desiredOutcome = 190;

        Assert.Equal(desiredOutcome, ArrayUtils.addthemarrays.AddArray(testArray1, testArray2));
    }

    [Fact]
    public void test_sub_array()
    {
        int[] testArray1 = {1, 4, 18, 7, 9, 53};
        int[] testArray2 = {2, 5, 19, 8, 10, 54};
        int desiredOutcome = -188;

        Assert.Equal(desiredOutcome, ArrayUtils.submissiveArray.Sub(testArray1, testArray2));
    }
}
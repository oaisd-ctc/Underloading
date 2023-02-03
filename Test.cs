using Underloading;
using Xunit;

public class Tests
{
    [Fact]
    public void TestAddgInt()
    {
        int a = 2;
        int b = 2;
        Assert.Equal(4, MathUtils.Add(a, b));
    }
    [Fact]
    public void TestAddFloat()
    {
        float a = 2;
        float b = 2;
        Assert.Equal(4, MathUtils.Add(a, b));
    }
    [Fact]
    public void TestAddDouble()
    {
        double a = 2;
        double b = 2;
        Assert.Equal(4, MathUtils.Add(a, b));
    }

    [Fact]
    public void TestSubtractInt()
    {
        int a = 4;
        int b = 2;
        Assert.Equal(2, MathUtils.Subtract(a, b));
    }
    [Fact]
    public void TestSubtractFloat()
    {
        float a = 4;
        float b = 2;
        Assert.Equal(2, MathUtils.Subtract(a, b));
    }
    [Fact]
    public void TestSubtractDouble()
    {
        double a = 4;
        double b = 2;
        Assert.Equal(2, MathUtils.Subtract(a, b));
    }

    [Fact]
    public void TestMultiplyInt()
    {
        int a = 3;
        int b = 2;
        Assert.Equal(6, MathUtils.Multiply(a, b));
    }   
    [Fact]
    public void TestMultiplyFloat()
    {
        float a = 3;
        float b = 2;
        Assert.Equal(6, MathUtils.Multiply(a, b));
    }    
    [Fact]
    public void TestMultiplyDouble()
    {
        double a = 3;
        double b = 2;
        Assert.Equal(6, MathUtils.Multiply(a, b));
    }    

    [Fact]
    public void TestDivideInt()
    {
        int a = 4;
        int b = 2;
        Assert.Equal(2, MathUtils.Divide(a, b));
    }
    [Fact]
    public void TestDivideFloat()
    {
        float a = 3;
        float b = 2;
        Assert.Equal(6, MathUtils.Multiply(a, b));
    }  
    [Fact]
    public void TestDivideDouble()
    {
        double a = 3;
        double b = 2;
        Assert.Equal(6, MathUtils.Multiply(a, b));
    }  

    [Fact]
    public void TestPowInt()
    {
        int a = 3;
        int b = 2;
        Assert.Equal(9, MathUtils.Pow(a, b));
    }
    [Fact]
    public void TestPowFloat()
    {
        float a = 3;
        float b = 2;
        Assert.Equal(9, MathUtils.Pow(a, b));
    }
    [Fact]
    public void TestPowDouble()
    {
        double a = 3;
        double b = 2;
        Assert.Equal(9, MathUtils.Pow(a, b));
    }

    [Fact]
    public void TestSqrtInt()
    {
        int a = 4;
        Assert.Equal(2.0000000000000013, MathUtils.Sqrt(a));
    }
    [Fact]
    public void TestSqrtFloat()
    {
        float a = 4;
        Assert.Equal(2.0000000000000013, MathUtils.Sqrt(a));
    }
    [Fact]
    public void TestSqrtDouble()
    {
        double a = 4;
        Assert.Equal(2.0000000000000013, MathUtils.Sqrt(a));
    }

    [Fact]
    public void TestMinInt()
    {
        int a = 4;
        int b = 2;
        Assert.Equal(2, MathUtils.Min(a, b));
    }
    [Fact]
    public void TestMinFloat()
    {
        float a = 4;
        float b = 2;
        Assert.Equal(2, MathUtils.Min(a, b));
    }
    [Fact]
    public void TestMinDouble()
    {
        double a = 4;
        double b = 2;
        Assert.Equal(2, MathUtils.Min(a, b));
    }

    [Fact]
    public void TestMaxInt()
    {
        int a = 1;
        int b = 2;
        Assert.Equal(2, MathUtils.Max(a, b));
    }
    [Fact]
    public void TestMaxFloat()
    {
        float a = 1;
        float b = 2;
        Assert.Equal(2, MathUtils.Max(a, b));
    }
    [Fact]
    public void TestMaxDouble()
    {
        double a = 1;
        double b = 2;
        Assert.Equal(2, MathUtils.Max(a, b));
    }

    [Fact]
    public void TestAbsInt()
    {
        int a = -1;
        Assert.Equal(1, MathUtils.Abs(a));
    }
    [Fact]
    public void TestAbsFloat()
    {
        float a = -1;
        Assert.Equal(1, MathUtils.Abs(a));
    }
    [Fact]
    public void TestAbsDouble()
    {
        double a = -1;
        Assert.Equal(1, MathUtils.Abs(a));
    }

    [Fact]
    public void TestModInt()
    {
        int a = 4;
        int b = 3;
        Assert.Equal(1, MathUtils.Mod(a, b));
    }
    [Fact]
    public void TestModFloat()
    {
        float a = 4;
        float b = 3;
        Assert.Equal(1, MathUtils.Mod(a, b));
    }
    [Fact]
    public void TestModDecimal()
    {
        decimal a = 4; 
        decimal b = 3;
        Assert.Equal(1, MathUtils.Mod(a, b));
    }
    
    [Fact]
    public void TestCircleAreaFromRadiusInt()
    {
        int a = 2;
        Assert.Equal(12, MathUtils.CircleAreaFromRadius(a));
    }
    [Fact]
    public void TestCircleAreaFromRadiusFloat()
    {
        float a = 2;
        Assert.Equal(12.571428298950195, MathUtils.CircleAreaFromRadius(a));
    }
    [Fact]
    public void TestCircleAreaFromRadiusDouble()
    {
        double a = 2;
        Assert.Equal(12.571428571428571, MathUtils.CircleAreaFromRadius(a));
    }
    
    [Fact]
    public void TestSurfaceAreaOfCubeFromOneSideInt()
    {
        int a = 2;
        Assert.Equal(24, MathUtils.SurfaceAreaOfCubeFromOneSide(a));
    }
    [Fact]
    public void TestSurfaceAreaOfCubeFromOneSideFloat()
    {
        float a = 2;
        Assert.Equal(24, MathUtils.SurfaceAreaOfCubeFromOneSide(a));
    }
    [Fact]
    public void TestSurfaceAreaOfCubeFromOneSideDouble()
    {
        double a = 2;
        Assert.Equal(24, MathUtils.SurfaceAreaOfCubeFromOneSide(a));
    }

    [Fact]
    public void TestCirclePerimeterFromRadiusInt()
    {
        int a = 2;
        Assert.Equal(12, MathUtils.CirclePerimeterFromRadius(a));
    }
    [Fact]
    public void TestCirclePerimeterFromRadiusFloat()
    {
        float a = 2;
        Assert.Equal(12, MathUtils.CirclePerimeterFromRadius(a));
    }
    [Fact]
    public void TestCirclePerimeterFromRadiusDouble()
    {
        double a = 2;
        Assert.Equal(12, MathUtils.CirclePerimeterFromRadius(a));
    }



}

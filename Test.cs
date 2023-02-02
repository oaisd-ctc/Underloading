using MyUtilities;
using Xunit;

public class Tests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(4, MathUtils.Add(2, 2));
    }
    [Fact]
    public void TestAdd(float a, float b)
    {
        Assert.Equal(4, MathUtils.Add(2, 2));
    }
    [Fact]
    public void TestAdd(double a, double b)
    {
        Assert.Equal(4, MathUtils.Add(2, 2));
    }

    [Fact]
    public void TestSubtract(int a, int b)
    {
        Assert.Equal(2, MathUtils.Subtract(4, 2));
    }
    [Fact]
    public void TestSubtract(float a, float b)
    {
        Assert.Equal(2, MathUtils.Subtract(4, 2));
    }
    [Fact]
    public void TestSubtract(double a, double b)
    {
        Assert.Equal(2, MathUtils.Subtract(4, 2));
    }

    [Fact]
    public void TestMultiply(int a, int b)
    {
        Assert.Equal(6, MathUtils.Multiply(3, 2));
    }   
    [Fact]
    public void TestMultiply(float a, float b)
    {
        Assert.Equal(6, MathUtils.Multiply(3, 2));
    }    
    [Fact]
    public void TestMultiply(double a, double b)
    {
        Assert.Equal(6, MathUtils.Multiply(3, 2));
    }    

    [Fact]
    public void TestDivide(int x, int y)
    {
        Assert.Equal(2, MathUtils.Divide(4, 2));
    }
    [Fact]
    public void TestDivide(float x, float y)
    {
        Assert.Equal(6, MathUtils.Multiply(3, 2));
    }  
    [Fact]
    public void TestDivide(double x, double y)
    {
        Assert.Equal(6, MathUtils.Multiply(3, 2));
    }  

    [Fact]
    public void TestPow(int x, int y)
    {
        Assert.Equal(9, MathUtils.Pow(3, 2));
    }
    [Fact]
    public void TestPow(float x, float y)
    {
        Assert.Equal(9, MathUtils.Pow(3, 2));
    }
    [Fact]
    public void TestPow(double x, double y)
    {
        Assert.Equal(9, MathUtils.Pow(3, 2));
    }

    [Fact]
    public void TestSqrt(int a)
    {
        Assert.Equal(2, MathUtils.Sqrt(4));
    }
    [Fact]
    public void TestSqrt(float a)
    {
        Assert.Equal(2, MathUtils.Sqrt(4));
    }
    [Fact]
    public void TestSqrt(double a)
    {
        Assert.Equal(2, MathUtils.Sqrt(4));
    }

    [Fact]
    public void TestMin(int a, int b)
    {
        Assert.Equal(2, MathUtils.Min(4, 2));
    }
    [Fact]
    public void TestMin(float a, float b)
    {
        Assert.Equal(2, MathUtils.Min(4, 2));
    }
    [Fact]
    public void TestMin(double a, double b)
    {
        Assert.Equal(2, MathUtils.Min(4, 2));
    }

    [Fact]
    public void TestMax(int a, int b)
    {
        Assert.Equal(2, MathUtils.Max(1, 2));
    }
    [Fact]
    public void TestMax(float a, float b)
    {
        Assert.Equal(2, MathUtils.Max(1, 2));
    }
    [Fact]
    public void TestMax(double a, double b)
    {
        Assert.Equal(2, MathUtils.Max(1, 2));
    }

    [Fact]
    public void TestAbs(int a)
    {
        Assert.Equal(1, MathUtils.Abs(-1));
    }
    [Fact]
    public void TestAbs(float a)
    {
        Assert.Equal(1, MathUtils.Abs(-1));
    }
    [Fact]
    public void TestAbs(double a)
    {
        Assert.Equal(1, MathUtils.Abs(-1));
    }

    [Fact]
    public void TestMod(int a, int b)
    {
        Assert.Equal(1, MathUtils.Mod(4, 3));
    }
    [Fact]
    public void TestMod(float a, float b)
    {
        Assert.Equal(1, MathUtils.Mod(4, 3));
    }
    [Fact]
    public void TestMod(decimal a, decimal b)
    {
        
        Assert.Equal(1, MathUtils.Mod(4, 3));
    }
    
    [Fact]
    public void TestCircleAreaFromRadius(int a)
    {
        Assert.Equal(12, MathUtils.CircleAreaFromRadius(2));
    }
    [Fact]
    public void TestCircleAreaFromRadius(float a)
    {
        Assert.Equal(12, MathUtils.CircleAreaFromRadius(2));
    }
    [Fact]
    public void TestCircleAreaFromRadius(double a)
    {
        Assert.Equal(12, MathUtils.CircleAreaFromRadius(2));
    }
    
    [Fact]
    public void TestSurfaceAreaOfCubeFromOneSide(int a)
    {
        Assert.Equal(24, MathUtils.SurfaceAreaOfCubeFromOneSide(2));
    }
    [Fact]
    public void TestSurfaceAreaOfCubeFromOneSide(float a)
    {
        Assert.Equal(24, MathUtils.SurfaceAreaOfCubeFromOneSide(2));
    }
    [Fact]
    public void TestSurfaceAreaOfCubeFromOneSide(double a)
    {
        Assert.Equal(24, MathUtils.SurfaceAreaOfCubeFromOneSide(2));
    }

    [Fact]
    public void TestCirclePerimeterFromRadius()
    {
        int a = 2;
        Assert.Equal(12, MathUtils.CirclePerimeterFromRadius(a));
    }
    [Fact]
    public void TestCirclePerimeterFromRadiusInt()
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

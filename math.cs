namespace MyUtilities
{
    public static class MathUtils
    {
    /// <summary>
    /// Finds the sum of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Add(int a, int b)
    {
        return a + b;
    }
    /// <summary>
    /// Finds the sum of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Add(float a, float b)
    {
        return a + b;
    }
    /// <summary>
    /// Finds the sum of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Finds the difference of the two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Subtract(int a, int b)
    {
        return a - b;
    }
    /// <summary>
    /// Finds the difference of the two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Subtract(float a, float b)
    {
        return a - b;
    }
    /// <summary>
    /// Finds the difference of the two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Finds the product of the two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Multiply(int a, int b)
    {
        return a * b;
    }    
    /// <summary>
    /// Finds the product of the two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Multiply(float a, float b)
        {
            return a * b;
        }    
    /// <summary>
    /// Finds the product of the two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Multiply(double a, double b)
    {
        return a * b;
    }    

    /// <summary>
    /// Finds the quotient of the two numbers
    /// </summary>
    /// <param name="x">Chosen number</param>
    /// <param name="y">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Divide(int x, int y)
    {
        return x / y;
    }
    /// <summary>
    /// Finds the quotient of the two numbers
    /// </summary>
    /// <param name="x">Chosen number</param>
    /// <param name="y">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Divide(float x, float y)
    {
        return x / y;
    }  
    /// <summary>
    /// Finds the quotient of the two numbers
    /// </summary>
    /// <param name="x">Chosen number</param>
    /// <param name="y">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Divide(double x, double y)
    {
        return x / y;
    }  

    /// <summary>
    /// Finds one number to the power of another
    /// </summary>
    /// <param name="x">Chosen number</param>
    /// <param name="y">Chosen number</param>
    /// <returns>
    /// A double that is the result one number to the power of another
    /// </returns>
    public static double Pow(int x, int y)
    {
        int i = x;
        while (i <= y)
        {
            x *= i;
        }
        return x;
    }
    /// <summary>
    /// Finds one number to the power of another
    /// </summary>
    /// <param name="x">Chosen number</param>
    /// <param name="y">Chosen number</param>
    /// <returns>
    /// A double that is the result one number to the power of another
    /// </returns>
    public static double Pow(float x, float y)
    {
        int i = Convert.ToInt32(x);
        while (i <= y)
        {
            x *= i;
        }
        return x;
    }
    /// <summary>
    /// Finds one number to the power of another
    /// </summary>
    /// <param name="x">Chosen number</param>
    /// <param name="y">Chosen number</param>
    /// <returns>
    /// A double that is the result one number to the power of another
    /// </returns>
    public static double Pow(double x, double y)
    {
        int i = Convert.ToInt32(x);
        while (i <= y)
        {
            x *= i;
        }
        return x;
    }

    /// <summary>
    /// Finds the square root of a number
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the result square rooting a number
    /// </returns>
    public static double Sqrt(int a)
    {
        double i = .01;
        while (i * i < a)
        {
            i += .01;
        }
        return i;
    }
    /// <summary>
    /// Finds the square root of a number
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the result square rooting a number
    /// </returns>
    public static double Sqrt(float a)
    {
        double i = .01;
        while (i * i < a)
        {
            i += .01;
        }
        return i;
    }
    /// <summary>
    /// Finds the square root of a number
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the result square rooting a number
    /// </returns>
    public static double Sqrt(double a)
    {
        double i = .01;
        while (i * i < a)
        {
            i += .01;
        }
        return i;
    }

    /// <summary>
    /// Finds the smaller of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the smaller of the two numbers
    /// </returns>
    public static double Min(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else 
        {
            return b;
        }
    }
    /// <summary>
    /// Finds the smaller of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the smaller of the two numbers
    /// </returns>
    public static double Min(float a, float b)
    {
        if (a < b)
        {
            return a;
        }
        else 
        {
            return b;
        }
    }
    /// <summary>
    /// Finds the smaller of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the smaller of the two numbers
    /// </returns>
    public static double Min(double a, double b)
    {
        if (a < b)
        {
            return a;
        }
        else 
        {
            return b;
        }
    }

    /// <summary>
    /// Finds the larger of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the larger of the two numbers
    /// </returns>
    public static double Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else 
        {
            return b;
        }
    }
    /// <summary>
    /// Finds the larger of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the larger of the two numbers
    /// </returns>
    public static double Max(float a, float b)
    {
        if (a > b)
        {
            return a;
        }
        else 
        {
            return b;
        }
    }
    /// <summary>
    /// Finds the larger of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the larger of the two numbers
    /// </returns>
    public static double Max(double a, double b)
    {
        if (a > b)
        {
            return a;
        }
        else 
        {
            return b;
        }
    }
    
    /// <summary>
    /// Finds the absolute value of a number
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the absolute value of the chosen number
    /// </returns>
    public static double Abs(int a)
    {
        if (a>0)
        {
            return a;
        }
        else 
        {
            return -1 * a;
        }
    }
    /// <summary>
    /// Finds the absolute value of a number
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the absolute value of the chosen number
    /// </returns>
    public static double Abs(float a)
    {
        if (a>0)
        {
            return a;
        }
        else 
        {
            return -1 * a;
        }
    }
    /// <summary>
    /// Finds the absolute value of a number
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the absolute value of the chosen number
    /// </returns>
    public static double Abs(double a)
    {
        if (a>0)
        {
            return a;
        }
        else 
        {
            return -1 * a;
        }
    }

    /// <summary>
    /// Finds the modulus of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Mod(int a, int b)
    {
        return a % b;
    }
    /// <summary>
    /// Finds the modulus of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Mod(float a, float b)
    {
        return a % b;
    }

    /// <summary>
    /// Finds the modulus of two numbers
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <param name="b">Chosen number</param>
    /// <returns>
    /// A double that is the result of the operation
    /// </returns>
    public static double Mod(decimal a, decimal b)
    {
        
        return Convert.ToDouble(a % b);
    }
    
    /// <summary>
    /// Finds the area of a circle from the radius
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the area of the circle
    /// </returns>
    public static double CircleAreaFromRadius(int a)
    {
        return a * a *22/7;
    }
    /// <summary>
    /// Finds the area of a circle from the radius
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the area of the circle
    /// </returns>
    public static double CircleAreaFromRadius(float a)
    {
        return a * a *22/7;
    }
    /// <summary>
    /// Finds the area of a circle from the radius
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the area of the circle
    /// </returns>
    public static double CircleAreaFromRadius(double a)
    {
        return a * a *22/7;
    }

    /// <summary>
    /// Finds the surface area of a cube
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the surface area of a cube
    /// </returns>
    public static double SurfaceAreaOfCubeFromOneSide(int a)
    {
        return a * a * 6;
    }
    /// <summary>
    /// Finds the surface area of a cube
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the surface area of a cube
    /// </returns>
    public static double SurfaceAreaOfCubeFromOneSide(float a)
    {
        return a * a * 6;
    }
    /// <summary>
    /// Finds the surface area of a cube
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the surface area of a cube
    /// </returns>
    public static double SurfaceAreaOfCubeFromOneSide(double a)
    {
        return a * a * 6;
    }

    /// <summary>
    /// Finds the perimeter of a circle from the radius
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the perimeter of the circle
    /// </returns>
    public static double CirclePerimeterFromRadius(int a)
    {
        return 22/7 * 2 * a;
    }
    /// <summary>
    /// Finds the perimeter of a circle from the radius
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the perimeter of the circle
    /// </returns>
    public static double CirclePerimeterFromRadius(float a)
    {
        return 22/7 * 2 * a;
    }
    /// <summary>
    /// Finds the perimeter of a circle from the radius
    /// </summary>
    /// <param name="a">Chosen number</param>
    /// <returns>
    /// A double that is the perimeter of the circle
    /// </returns>
    public static double CirclePerimeterFromRadius(double a)
    {
        return 22/7 * 2 * a;
    }



}
}






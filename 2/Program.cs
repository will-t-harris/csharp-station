using System;

class Binary
{
    public static void Main()
    {
        int x, y, result;
        float floatresult;

        x = 7;
        y = 5;

        result = x + y;
        Console.WriteLine("x+y: {0}", result); // writes 12 to console

        result = x - y;
        Console.WriteLine("x-y: {0}", result); // writes 2 to console

        result = x * y;
        Console.WriteLine("x*y: {0}", result); // writes 35 to console

        result = x / y;
        Console.WriteLine("x/y: {0}", result); // writes 1 to console (doesn't include remainder because we're doing int division, need float or decimal for remainders)
        
    }
}
using System;

class Unary
{
    public static void Main()
    {
        int unary = 0;
        int preIncrement;
        int preDecrement;
        int postIncrement;
        int postDecrement;
        int positive;
        int negative;
        sbyte bitNot;
        bool logNot;

        preIncrement = ++unary;
        Console.WriteLine("pre-Increment: {0}", preIncrement); // writes 1 to console

        preDecrement = --unary;
        Console.WriteLine("pre-Decrement: {0}", preDecrement); // writes 0 to console

        postDecrement = unary--;
        Console.WriteLine("Post-Decrement: {0}", postDecrement); // writes 0 to console

        postIncrement = unary++;
        Console.WriteLine("Post-Increment: {0}", postIncrement); // writes -1 to console

        Console.WriteLine("Final value of Unary: {0}", unary); // writes 0 to console

        positive = -postIncrement;
        Console.WriteLine("Positive: {0}", positive); // writes 1 to console

        negative = +postIncrement;
        Console.WriteLine("Negative: {0}", negative); // writes -1 to console

        bitNot = 0;
        bitNot = (sbyte)(~bitNot);
        Console.WriteLine("Bitwise Not: {0}", bitNot); // writes -1 to console

        logNot = false;
        logNot = !logNot;
        Console.WriteLine("Logical Not: {0}", logNot); // writes True to console
    }
}
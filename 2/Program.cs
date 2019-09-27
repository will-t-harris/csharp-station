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

        //! These two perform the operation and THEN return the value
        preIncrement = ++unary;
        Console.WriteLine("pre-Increment: {0}", preIncrement); // writes 1 to console

        preDecrement = --unary;
        Console.WriteLine("pre-Decrement: {0}", preDecrement); // writes 0 to console

        //! These two return the value first and THEN perform the operation
        postDecrement = unary--;
        Console.WriteLine("Post-Decrement: {0}", postDecrement); // writes 0 to console

        postIncrement = unary++;
        Console.WriteLine("Post-Increment: {0}", postIncrement); // writes -1 to console

        Console.WriteLine("Final value of Unary: {0}", unary); // writes 0 to console

        //! minus operator flips the sign
        positive = -postIncrement;
        Console.WriteLine("Positive: {0}", positive); // writes 1 to console

        //! plus operator does nothing to the sign
        negative = +postIncrement;
        Console.WriteLine("Negative: {0}", negative); // writes -1 to console

        bitNot = 0;
        bitNot = (sbyte)(~bitNot); //! this is an example of the 'cast operator' which explicitly casts the value in bitNot to sbyte data type
        Console.WriteLine("Bitwise Not: {0}", bitNot); // writes -1 to console

        logNot = false;
        logNot = !logNot; //! logical not flips boolean to opposite value
        Console.WriteLine("Logical Not: {0}", logNot); // writes True to console
    }
}
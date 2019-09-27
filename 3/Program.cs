using System;

class IfSelect
{
    public static void Main()
    {
        string myInput;
        int myInt;

        Console.Write("Please enter a number: ");
        myInput = Console.ReadLine();
        myInt = Int32.Parse(myInput);

        // Single decision and action with braces
        if (myInt > 0)
        {
            Console.WriteLine("Your number {0} is greater than zero.", myInt);
        }

        // Single decision and action without brackets
        if (myInt < 0)
            Console.WriteLine("Your number {0} is less than zero.", myInt);

        // Either/or decision
        if (myInt != 0)
        {
            Console.WriteLine("Your number {0} is not equal to zero.", myInt);
        }
        else
        {
            Console.WriteLine("Your number {0} is equal to zero.", myInt);
        }
    }
}
// Namespace
using System;

// Program start class
class InteractiveWelcome
{
    // Main begins program execution
    public static void Main()
    {
        // Write to console/get input
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.Write("Hello, {0}! ", name);
        Console.WriteLine("Welcome to the C# Station Tutorial!");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        var name = Console.ReadLine();
        Console.Write("What is your last name? ");
        var surname = Console.ReadLine();
        Console.WriteLine($"Your name is {surname}, {name} {surname}.");
    }
}
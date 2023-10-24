using System;

public class GallowsRenderer
{
    public void ShowGallows(int wrongGuessCount)
    {
        switch (wrongGuessCount)
        {
            case 1:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|    ");
                Console.WriteLine("|    ");
                Console.WriteLine("|    ");
                Console.WriteLine("===  ");
                break;
            case 2:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|   O");
                Console.WriteLine("|    ");
                Console.WriteLine("|    ");
                Console.WriteLine("===  ");
                break;
            case 3:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|    O");
                Console.WriteLine("|    |");
                Console.WriteLine("|     ");
                Console.WriteLine("===   ");
                break;
            case 4:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|    O ");
                Console.WriteLine("|    |\\ ");
                Console.WriteLine("|      ");
                Console.WriteLine("===    ");
                break;
            case 5:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|    O ");
                Console.WriteLine("|   /|\\ ");
                Console.WriteLine("|      ");
                Console.WriteLine("===    ");
                break;
            case 6:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|    O ");
                Console.WriteLine("|   /|\\ ");
                Console.WriteLine("|   /   ");
                Console.WriteLine("===    ");
                break;
            case 7:
                Console.WriteLine("\n+---+");
                Console.WriteLine("|    O ");
                Console.WriteLine("|   /|\\ ");
                Console.WriteLine("|   / \\ ");
                Console.WriteLine("===    ");
                break;
        }
    }
}
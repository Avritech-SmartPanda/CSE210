using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int count = 0;
 
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            count++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {count} guesses.");
                Console.Write($"Would you like to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    Main(args);
                }
                else
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }

        }
    }
}
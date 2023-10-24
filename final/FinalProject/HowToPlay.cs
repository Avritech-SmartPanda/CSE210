using System;

public class HowToPlay
{

    private string _howToPlay = $@"
HOW TO PLAY 
===========================================
The Game
Hangman is a classic word game in which you must guess the secret word one letter at a time.
At the start of a game, you are presented with an set of blank lines representing the missing letters of the word.

The aim of the game is to find the hidden word before the hangman is fully drawn.

* Guess one letter at a time to reveal the secret word.
* Each correct guess of a letter fills in the blanks.  . 
* Each incorrect guess adds another part to the hangman. 
* You only get 7 incorrect guesses.
===========================================

*** Press Enter to return to menu ***";

    public void GetInstructions()
    {
        Console.Clear();
        Console.Write(_howToPlay);

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }

}
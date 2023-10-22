using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Player
{
    // Attributes
    public string randomWord { get; set; }
    public string showRandomWord { get; set; }
    public string guessedLetter { get; set; }
    public List<string> lettersGuessed { get; set; }
    public List<string> wrongGuessList { get; set; }
    public List<string> rightGuessList { get; set; }
    public List<string> emptyList { get; set; }
    public string guesses { get; set; }
    public string wrongGuesses { get; set; }
    public int wrongGuessCount;
    public int correctGuessCount;
    public int numberWordsGuessed;
    public int score;
    // Constructors
    public Player()
    {
        randomWord = string.Empty;
        showRandomWord = string.Empty;
        guessedLetter = string.Empty;
        lettersGuessed = new List<string>();
        wrongGuessList = new List<string>();
        rightGuessList = new List<string>();
        emptyList = new List<string>();
        guesses = string.Empty;
        wrongGuesses = string.Empty;
        wrongGuessCount = 0;
        correctGuessCount = 0;
        numberWordsGuessed = 0;
        score = 0;
    }
    // Methods



    public bool GameOver()
    {
        return false;
    }

    public void ShowRandomWord()
    {

    }
    public void CheckLatestGuess(string newGuess)
    {



    }


}
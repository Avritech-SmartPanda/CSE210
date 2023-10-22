using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Hangman
{
    // Attributes
    private string _letterGuessed;
    private Player player;
    private GallowsRenderer gallowsRenderer;
    private WordGenerator randomWord;
    private PrintLines printLines;
    private ScoreBoard simpleScore = new ScoreBoard(new ScoreSimple());
    private ScoreBoard complexScore = new ScoreBoard(new ScoreComplex());
    private ScoreBoard scrabbleScore = new ScoreBoard(new ScoreScrabble());


    // Constructors
    public Hangman()
    {
        player = new Player();
        gallowsRenderer = new GallowsRenderer();
        randomWord = new WordGenerator();
        printLines = new PrintLines();
    }
    // Methods

    public void StartGame(string fileName)
    {

    }
    private void SelectRandomWord(string fileName)
    {
       
    }
    private void DisplayRandomWord()
    {
        
    }

    private void PromptPlayerForLetter()
    {
      
    }
    private void CheckPlayerGuess()
    {
       
    }


    private void ShowGallows()
    {
        
    }

    private void ShowLettersGuessesRight()
    {
        Console.WriteLine($"\n{player.showRandomWord}\n");
    }

    private void ShowLettersGuessedWrong()
    {
        Console.WriteLine($"\n{player.wrongGuesses}\n");
    }

  

    private void ShowPlayerScore()
    {
        
        
    }

    private void GameOver()
    {
       
       
    }


}
using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Hangman
{

    private string _letterGuessed;
    private Player _player;
    private GallowsRenderer gallowsRenderer;
    private Word _randomWord;
    private PrintLines _printLines;
    private ScoreBoard _simpleScore = new ScoreBoard(new ScoreSimple());
    private ScoreBoard _complexScore = new ScoreBoard(new ScoreComplex());
    private ScoreBoard _scrabbleScore = new ScoreBoard(new ScoreScrabble());



    public Hangman()
    {
        _player = new Player();
        gallowsRenderer = new GallowsRenderer();
        _randomWord = new Word();
        _printLines = new PrintLines();
    }


    public void StartGame(string fileName)
    {
        Console.Clear();
        SelectRandomWord(fileName);
        _player.ShowRandomWord();
        do
        {
            Console.Clear();
            ShowTitle();
            ShowGallows();
            ShowLettersGuessesRight();
            ShowLettersGuessedWrong();
            ShowNumberOfGuesses();
            PromptPlayerForLetter();
            CheckPlayerGuess();
        } while (!_player.GameOver());

        GameOver();
        PlayAgain();

    }
    private void SelectRandomWord(string fileName)
    {
        _player.randomWord = _randomWord.GetRandomWord(fileName);
    }
    private void DisplayRandomWord()
    {
        Console.WriteLine("\n{0}", _player.randomWord);
    }

    private void PromptPlayerForLetter()
    {
        do
        {
            Console.Write("Guess a letter >>  ");
            string g = Console.ReadLine();
            _letterGuessed = g.Substring(0, 1);
        } while (_player.CheckIfGuessed(_player, _letterGuessed));

        _player.lettersGuessed.Add(_letterGuessed);
    }
    private void CheckPlayerGuess()
    {
        _player.CheckLatestGuess(_letterGuessed);
        _player.ShowRandomWord();
    }

    private void PlayAgain()
    {
        Console.WriteLine($"\nPress ENTER if you would like to play again.");

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }

    private void ShowNumberOfGuesses()
    {
        Console.WriteLine($"\nGuesses Left = {_player.wrongGuessCount}/7\n");
    }

    private void ShowGallows()
    {
        gallowsRenderer.ShowGallows(_player.wrongGuessCount);
    }

    private void ShowLettersGuessesRight()
    {
        Console.WriteLine($"\n{_player.showRandomWord}\n");
    }

    private void ShowLettersGuessedWrong()
    {
        Console.WriteLine($"\n{_player.wrongGuesses}\n");
    }

    private void ShowTitle()
    {
        Console.WriteLine($"*** Lets Play Hangman ***\n");
    }

    private void ShowPlayerScore()
    {
        if (!_player.PlayerLost())
        {
            _simpleScore.DisplayScore(_player.correctGuessCount, _player.rightGuessList, _player.randomWord);
            _scrabbleScore.DisplayScore(_player.correctGuessCount, _player.rightGuessList, _player.randomWord);
            _complexScore.DisplayScore(_player.correctGuessCount, _player.rightGuessList, _player.randomWord);
        }
        else
        {
            _simpleScore.DisplayScore(0, _player.emptyList, _player.randomWord);
            _scrabbleScore.DisplayScore(0, _player.emptyList, _player.randomWord);
            _complexScore.DisplayScore(0, _player.emptyList, _player.randomWord);
        }
    }

    private void GameOver()
    {
        Console.Clear();  // This will clear the console
        if (_player.GameOver() && _player.PlayerWon())
        {
            Console.WriteLine("*** Congratulations You Won! ***");
        }
        else
        {
            Console.WriteLine("*** Sorry, you lost! ***");
        }
        ShowGallows();
        ShowNumberOfGuesses();
        Console.WriteLine($"\nThe word was - {_player.randomWord}\n");
        ShowPlayerScore();
    }


}
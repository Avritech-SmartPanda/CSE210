using System;

public class ScoreScrabble : ScoringRules
{
    // Attributes
    Dictionary<string, int> scrabble = new Dictionary<string, int>()
        {
        };
    private int score;

    // Constructors


    // Methods
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
       
        return score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your scrabble word score: {score} ");
    }





}
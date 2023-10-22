using System;

public class ScoreComplex : ScoringRules
{
    // Attributes
    private int score;
    private int len;

    // Constructors


    // Methods
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
            
        return score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your complex word score: {score} ");
    }





}
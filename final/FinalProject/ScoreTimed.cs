using System;
using System.Threading;

public class ScoreTimed : ScoringRules
{
    // Attributes
    private int score;

    // Constructors


    // Methods
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        return 0;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your simple word score: {score} ");
    }


}
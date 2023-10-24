using System;
using System.Threading;

public class ScoreTimed : ScoringRules
{

    private int score;

    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        int totalScore = 0;    
        return totalScore;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your simple word score: {score} ");
    }


}
using System;

public class ScoreSimple : ScoringRules
{

    private int _score;

    public override int CalculateScore(int numOfGuesses, List<string> letters, string word)
    {
        _score = numOfGuesses;
        return _score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your simple word score: {_score} ");
    }
}
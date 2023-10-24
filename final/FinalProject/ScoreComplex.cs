using System;

public class ScoreComplex : ScoringRules
{

    private int _score;
    private int _wordLegth;


    public override int CalculateScore(int numOfGuesses, List<string> letters, string word)
    {
        _wordLegth = word.Length;
        if (_wordLegth <= 7)
        {
            _score = numOfGuesses * 2;
        }
        else if (_wordLegth > 7 & _wordLegth <= 9)
        {
            _score = numOfGuesses * 3;
        }
        else
        {
            _score = numOfGuesses * 4;
        }
        return _score;
    }
    public override void ShowScore()
    {
        Console.WriteLine($"Your complex word score: {_score} ");
    }





}
using System;

public class ScoreBoard
{

    private ScoringRules _scoringRules;


    public ScoreBoard(ScoringRules scoringRules)
    {
        _scoringRules = scoringRules;
    }



    public void DisplayScore(int numOfGuesses, List<string> letters, string word)
    {
        int _score = _scoringRules.CalculateScore(numOfGuesses, letters, word);
        _scoringRules.ShowScore();
    }


}
using System;

public class Word
{
    private string _randomWord;
    private int _index;

    public string GetRandomWord(string fileName)
    {
        Random random = new Random();
        WordDictionary dictionary = new WordDictionary();
        List<string> wordList = dictionary.GetList(fileName);

        _index = random.Next(wordList.Count);
        _randomWord = wordList[_index];
        return _randomWord;
    }

    public int GetRandomWordCount()
    {
        return _randomWord.Length;
    }

}
using System;

public class Dictionary
{
    // Attributes
    private List<string> _dictionary = new List<string> ();
   
    // Constructors
    public List<string> GetList(string fileName)
    {
        return _dictionary;
    }
    public void AddWord(string word)
    {
        _dictionary.Add(word);
    }
    // Methods

}
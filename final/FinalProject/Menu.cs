using System;

public abstract class Menu
{
    // Attributes
    public string _menu { get; set; }
    protected string _userInput { get; set; }
    protected int _userChoice;
    protected int _action;
    protected string _wordFileName { get; set; }


    // Constructors


    // Methods
    public abstract void DisplayMenu();
    public int UserChoice()
    {
                return _userChoice;
    }
    public abstract void MenuChoice();

}
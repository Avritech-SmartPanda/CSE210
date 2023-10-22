using System;

public class ListMenu : Menu
{
    // Attributes 
    private new string _menu = $@"
                List Options
===========================================
Your list Options are:
1. Colors
2. Sports
3. Seasons
4. Back to Game Menu
===========================================
Which list would you like to use?  ";

    // Constructors


    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        while (_action != 4)
        {
            Hangman game = new Hangman();
            _action = UserChoice();
          
        }
    }
}

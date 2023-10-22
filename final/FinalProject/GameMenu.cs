using System;

public class GameMenu : Menu
{
    // Attributes 
    private new string _menu = $@"
                Game Options
===========================================
Your Game Options are:
1. Random Words
2. Pick your word topic
3. Back to Main Menu
===========================================
Which game would you like to play?  ";

    // Constructors

    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        Menu listMenu = new ListMenu();

        while (_action != 3)
        {
            _action = UserChoice();

        }
    }
}

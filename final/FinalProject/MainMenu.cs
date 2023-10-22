using System;

public class MainMenu : Menu
{
    // Attributes
    private new string _menu = $@"
             Main Menu Options
===========================================
Please select one of the following options:
1. Play Game
2. How to Play
3. Quit
===========================================
Select an option from the menu:  ";

    private string _welcome = @"
*******************************************
***                                     ***
***          Welcome to Hangman         ***
***                                     ***
*******************************************";
    private string _goodbye = @"
*******************************************
***                                     ***
***    Thank you for playing Hangman!   ***
***                                     ***
*******************************************";

    // Constructors

    // Methods
    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {

    }
    private void PrintWelcome()
    {
        Console.Clear();
        Console.Write($"{_welcome}\n\n");
    }
    private void PrintGoodbye()
    {
        Console.Clear();
        Console.Write($"{_goodbye}\n\n");
    }
}

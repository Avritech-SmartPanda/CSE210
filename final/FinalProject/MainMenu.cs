using System;

public class MainMenu : Menu
{

    private new string _menu = $@"
Please select one of the following options:
===========================================
1. Play Game
2. How to Play
3. Quit
===========================================
Select an option from the menu:  ";

    private string _welcome = @"
*******************************************
*****        Welcome to Hangman       *****
*******************************************";
    private string _goodbye = @"
*******************************************
***    Thank you for playing Hangman!   ***
*******************************************";




    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        Menu gameMenu = new GameMenu();
        DisplayWelcome();

        while (_action != 3)
        {
            _action = UserChoice();
            switch (_action)
            {
                case 1: // Play Game - Untimed / Timed
                    Console.Clear();
                    gameMenu.MenuChoice();
                    break;
                case 2: // How to Play
                    HowToPlay info = new HowToPlay();
                    info.GetInstructions();
                    break;
                case 3: // Quit
                    DisplayGoodbye();
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
    private void DisplayWelcome()
    {
        Console.Clear();
        Console.Write($"{_welcome}\n\n");
    }
    private void DisplayGoodbye()
    {
        Console.Clear();
        Console.Write($"{_goodbye}\n\n");
    }
}
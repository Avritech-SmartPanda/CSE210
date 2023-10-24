using System;

public class GameMenu : Menu
{

    private new string _menu = $@"
Your Game Options are:
===========================================
1. Random Words
2. Pick your word topic
3. Back to Main Menu
===========================================
Which game would you like to play?  ";


    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        Menu listMenu = new ListMenu();

        while (_userChoice != 3)
        {
            _userChoice = UserChoice();
            switch (_userChoice)
            {
                case 1: // Random Words
                    _wordFileName = "randomWords.txt";
                    Hangman game = new Hangman();
                    game.StartGame(_wordFileName);
                    break;
                case 2: // Pick your word topic
                    Console.Clear();
                    listMenu.MenuChoice();
                    break;
                case 3: // Back to Main Menu
                    Console.Clear();
                    break;
                default:  // Invalid choice
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
}
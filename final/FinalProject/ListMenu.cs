using System;

public class ListMenu : Menu
{

    private new string _menu = $@"
Your list Options are:
===========================================
1. Colors
2. Continents
3. Oceans
4. Seasons
5. Back to Game Menu
===========================================
Which list would you like to use?  ";

    public override void DisplayMenu()
    {
        Console.Write(_menu);
    }
    public override void MenuChoice()
    {
        while (_action != 5)
        {
            Hangman _hangman = new Hangman();
            _action = UserChoice();
            switch (_action)
            {
                case 1:
                    _wordFileName = "colors.txt";
                    _hangman.StartGame(_wordFileName);
                    break;
                case 2:
                    _wordFileName = "continents.txt";
                    _hangman.StartGame(_wordFileName);
                    break;
                case 3:
                    _wordFileName = "oceans.txt";
                    _hangman.StartGame(_wordFileName);
                    break;
                case 4:
                    _wordFileName = "seasons.txt";
                    _hangman.StartGame(_wordFileName);
                    break;
                case 5:
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine($"\nPlease enter a valid option.");
                    break;
            }
        }
    }
}
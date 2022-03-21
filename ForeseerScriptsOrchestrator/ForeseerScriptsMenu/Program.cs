using System;
using System.Collections.Generic;

namespace ForeseerScriptsMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentSelection = 0;
            string[] menuOptions = new string[] { "Full Foreseer Server Setup", "Setup a File Transfer Scheduel", "Exit"};
            MenuDisplaySystem menu = new MenuDisplaySystem(menuOptions);
            menu.Generate(currentSelection);
            bool exit = false;
            do
            {
                string result = "";
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        if (currentSelection == menuOptions.Length - 1)
                        {
                            currentSelection = 0;
                        }
                        else
                        {
                            currentSelection += 1;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (currentSelection == 0)
                        {
                            currentSelection = menuOptions.Length - 1;
                        }
                        else
                        {
                            currentSelection -= 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        MainMenuController menuControl = new MainMenuController();
                        result = menuControl.runSelectedOption(menuOptions, currentSelection);
                        break;
                }
                Console.Clear();
                menu.Generate(currentSelection);
                if (result.ToLower() == "exit")
                {
                    exit = true;
                }

            } while (!exit);
        }
    }
}

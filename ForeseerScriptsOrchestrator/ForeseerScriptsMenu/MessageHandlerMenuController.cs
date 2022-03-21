using System;

namespace ForeseerScriptsMenu
{
    internal class MessageHandlerMenuController
    {
        internal bool TrueFalseRequest(string messageToSend, bool shouldClear)
        {
            string[] boolMenuRepresentation = new string[] { "Yes", "No" };
            MenuDisplaySystem menuDisplay = new MenuDisplaySystem(boolMenuRepresentation);
            if (shouldClear)
            {
                Console.Clear();
            }
            menuDisplay.GenerateTrueFalse(0, messageToSend);
            bool exit = false;
            bool result = false;
            int currentSelection = 0;
            do
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        if (currentSelection == boolMenuRepresentation.Length - 1)
                        {
                            currentSelection = 0;
                        }
                        else
                        {
                            currentSelection += 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (currentSelection == 0)
                        {
                            currentSelection = boolMenuRepresentation.Length - 1;
                        }
                        else
                        {
                            currentSelection -= 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (currentSelection == 0)
                        {
                            result = true;
                            exit = true;
                        }
                        else
                        {
                            result = false;
                            exit = true;
                        }
                        
                        break;
                }
                if (shouldClear)
                {
                    Console.Clear();
                }
                menuDisplay.GenerateTrueFalse(currentSelection, messageToSend);
                
            } while (!exit);

            return result;
        }
    }
}
using System;

namespace ForeseerScriptsMenu
{
    internal class MenuDisplaySystem
    {
        private string[] menuOptions;

        public MenuDisplaySystem(string[] menuOptions)
        {
            this.menuOptions = menuOptions;
        }

        internal void Generate(int _currentSelection)
        {
            Console.Clear();
            Console.WriteLine();
            int currentSelection = _currentSelection;
            Console.CursorVisible = false;
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == currentSelection)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(menuOptions[i]);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(menuOptions[i]);
                }
            }
        }

        internal void GenerateTrueFalse(int _currentSelection, string requestMessage)
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write($"{requestMessage}: ");
            int currentSelection = _currentSelection;
            Console.CursorVisible = false;
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == currentSelection)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write (menuOptions[i]);
                    Console.ResetColor();
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(menuOptions[i]);
                    Console.Write("  ");
                }
            }
        }

        internal void GenerateTrueFalseNoClear(int _currentSelection, string requestMessage)
        {
            Console.WriteLine();
            Console.Write($"{requestMessage}: ");
            int currentSelection = _currentSelection;
            Console.CursorVisible = false;
            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (i == currentSelection)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(menuOptions[i]);
                    Console.ResetColor();
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(menuOptions[i]);
                    Console.Write("  ");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeseerScriptsMenu
{
    class MainMenuController
    {
        internal string runSelectedOption(string[] menuOptions, int currentSelection)
        {
            switch (menuOptions[currentSelection].ToLower())
            {
                case "full foreseer server setup":
                    {
                        FullForeseerSetup setupForeseerServer = new FullForeseerSetup();
                        string result = setupForeseerServer.Start();
                        return result;
                    }

                case "setup a file transfer scheduel":
                    {
                        SetupFileTransferSchedule setupFileTransfer = new SetupFileTransferSchedule();
                        string result = setupFileTransfer.Start();
                        return result;
                    }

                case "exit":
                    {
                        SetupFileTransferSchedule setupFileTransfer = new SetupFileTransferSchedule();
                        return "exit";
                    }

                default:
                    return "Error: not a valid choice";
            }
        }
    }
}

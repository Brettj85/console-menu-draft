using System;

namespace ForeseerScriptsMenu
{
    internal class FullForeseerSetup
    {
        string serverToDeploy;
        string serverAdminUser;
        string serverAdminPass;
        string directoryToExpose;
        string origanatingDirectory;
        string destinationDirectory;
        string directoryToPlaceutilitys;
        bool deployScripthostBackupService;
        internal string Start()
        {
            ConsoleMesageHandler consoleMessenger = new ConsoleMesageHandler();
            serverToDeploy = consoleMessenger.SendReceive("Enter Server name: ");
            serverAdminUser = consoleMessenger.SendReceive("Enter Server Admin UserName:  ");
            serverAdminPass = consoleMessenger.SendReceive("Enter Server Admin Password: ");
            directoryToExpose = consoleMessenger.SendReceive("Enter Directory to Expose: ");
            origanatingDirectory = consoleMessenger.SendReceive("Enter Directory of File to Transfer For Scripthost Backups: ");
            destinationDirectory = consoleMessenger.SendReceive("Enter Destination Directory For Scripthost Backups: ");
            directoryToPlaceutilitys = consoleMessenger.SendReceive("Enter Directory To House ScripthostFileTransferUtility.exe on Foreseer Server: ");
            deployScripthostBackupService = consoleMessenger.Choice("deploy Scripthost backup service for this server ", true);
            bool result = reviewData();
            //if result is true run all the server modifycations
            return "done";
        }

        private bool reviewData()
        {
            bool choiceMade = false;
            bool isCorrect = false;
            do
            {
                Console.WriteLine($"Server to Deploy: { serverToDeploy }");
                Console.WriteLine($"Directory to Expose: { directoryToExpose }");
                Console.WriteLine($"Origanating Directory For File Transfer: { origanatingDirectory }");
                Console.WriteLine($"Destination Directory For File Transfer { destinationDirectory }");
                Console.WriteLine($"Location to Place Utilities { directoryToPlaceutilitys }");
                Console.WriteLine($"Deploy Scripthost Backup { deployScripthostBackupService.ToString() }");
                ConsoleMesageHandler consoleMessenger = new ConsoleMesageHandler();
                isCorrect = consoleMessenger.ChoiceNoClear("Is All Info Correct ", false);
                Console.Clear();
            } while (!choiceMade);
            
            return isCorrect;
        }
    }
}
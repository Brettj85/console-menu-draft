using System;

namespace ForeseerScriptsMenu
{
    internal class ConsoleMesageHandler
    {
        internal void Send(string messageToSend)
        {
            Console.Clear();
            Console.WriteLine(messageToSend);
        }

        internal string Receive()
        {
            string result = "";
            result = Console.ReadLine();
            return result;
        }

        internal string SendReceive(string messageToSend)
        {
            Send(messageToSend);
            string result = "";
            result = Receive();
            return result;
        }

        internal bool Choice(string messageToSend, bool shouldClear )
        {
            MessageHandlerMenuController menucontroller = new MessageHandlerMenuController();
            bool result = menucontroller.TrueFalseRequest(messageToSend, shouldClear);
            return result;
        }

        internal bool ChoiceNoClear(string messageToSend, bool shouldClear)
        {
            MessageHandlerMenuController menucontroller = new MessageHandlerMenuController();
            bool result = menucontroller.GenerateTrueFalseNoClear(messageToSend, shouldClear);
            return result;
        }
    }
}
using ExtraTerminalCommands.Networking;
using System;
using System.Collections.Generic;
using System.Text;
using TerminalApi.Classes;
using static TerminalApi.TerminalApi;

namespace ExtraTerminalCommands.TerminalCommands
{
    internal class ClearScreenCommand
    {
        public static string description = "Clears the terminal view.";
        public static void clearScreenCommand()
        {
            CommandInfo cmdInfo = new CommandInfo
            {
                Category = "none",
                Description = description,
                DisplayTextSupplier = onClear
            };
            AddCommand("clear", cmdInfo);
            AddCommand("cl", new CommandInfo { Category = "none", Description = description, DisplayTextSupplier = onClear });
            AddCommand("cls", new CommandInfo { Category = "none", Description = description, DisplayTextSupplier = onClear });
        }

        private static string onClear()
        {
            if(ETCNetworkHandler.Instance.clearCmdDisabled)
            {
                return "This command is disabled by the host.\n";
            }
            return "";
        }

    }
}

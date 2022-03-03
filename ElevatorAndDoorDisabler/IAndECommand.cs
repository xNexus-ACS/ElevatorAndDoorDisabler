using CommandSystem;
using System;
using Exiled.Permissions.Extensions;

namespace ElevatorAndDoorDisabler
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class IAndECommand : ICommand
    {
        public string Command { get; } = "dpa";
        public string[] Aliases { get; } = null;
        public string Description { get; } = "Disable door and elevators, execute again for enable again";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission(MainClass.singleton.Config.CommandPerm))
            {
                response = "You dont have perms to execute this command";
                return false;
            }

            if (MainClass.singleton.Ex.IAndE)
            {
                MainClass.singleton.Ex.IAndE = false;
                response = "Elevators and doors disabled";
                return true;
            }

            MainClass.singleton.Ex.IAndE = true;
            response = "Elevators and doors enabled";
            return true;
        }
    }
}
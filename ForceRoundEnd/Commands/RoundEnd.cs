using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;
using System;
using System.Linq;

namespace ForceRoundEnd.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class RoundEnd : ParentCommand
    {
        public RoundEnd() => LoadGeneratedCommands();

        public override string Command { get; } = "forceend";

        public override string[] Aliases { get; } = new string[] { "roundend", "fe", "re" };

        public override string Description { get; } = "Forces the round to end instantly";

        public override void LoadGeneratedCommands() { }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!CommandProcessor.CheckPermissions(((CommandSender)sender), "forceend", PlayerPermissions.RoundEvents, "ForceRoundEnd", false))
            {
                response = "You do not have permission to run this command!";
                return false;
            }

            if (arguments.Count != 0)
            {
                response = "Usage: forceend";
                return false;
            }

            if (!Round.IsStarted)
            {
                response = "Please start the round before using this command!";
                return false;
            }

            if (Player.List.Count() == 0)
            {
                response = "Please have at least 1 player before attempting to run this command";
                return false;
            }

            RoundSummary.singleton._keepRoundOnOne = false;
            if (Player.List.Count() > 1)
            {
                RoundSummary.RoundLock = false;
                RoundSummary.singleton.ForceEnd();
            } 
            response = "The round has ended now";
            return true;
        }
    }
}

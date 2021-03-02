using CommandSystem;
using Exiled.API.Features;
using System;
using Exiled.Permissions.Extensions;

namespace ClassBroadcast.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Help : ICommand
    {
        public string Command { get; } = "help classbroadcast";

        public string[] Aliases { get; } =
        {
            "h cbc",
            "help c broadcast",
            "help classbc",
            "help class broadcast",
            "help c broadcast"
        };

        public string Description { get; } = "Basically, helps you to understand the configs of this plugin";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.At(2) != "help classbroadcast")
            {
                response = "Command failed, incorrect arguments. Try: help classbc";
                return false;
            }
            else
            {
                response = $"Hello, {sender.LogName}. If you are having troubles with this plugin i recommend you to:\n1. Check if your class's name is correct (https://discord.com/channels/656673194693885975/668962626780397569/668964776147288094).\n2. Check if you set the class's broadcast time too, not only the message.\n3. If you don't what you need to do in plugin's config, just check here:\nbroadcasts_to_class:\nScp173: You are so strong\nbroadcasts_to_class_durations:\nScp173: 3\n4. If you have any other troubles, contact me on discord, An4r3w#1206 (tag might be different)";
                return true;
            }
        }
    }
}

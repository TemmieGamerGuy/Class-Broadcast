using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClassBroadcast
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled? true = yes, false = nope")]
        public bool IsEnabled { get; set; } = true;

        [Description("Set the message of the broadcast that will appear. If you want add class just type the name of the class under ClassD. If you want remove a class just delete the name (The class does not must be in 'BroadcastsToClassDurations' down here)")]
        public Dictionary<RoleType, string> BroadcastsToClass { get; set; } = new Dictionary<RoleType, string>() { { RoleType.ClassD, "You are a prisoner slave good luck" } };


        [Description("Set the time of the broadcast that will appear. If you want add class just type the name of the class under ClassD (The class needs to be in 'BroadcastsToClass' up here.) If you want remove a class just delete the name (The class does not must be in 'BroadcastsToClass' up here)")]
        public Dictionary<RoleType, ushort> BroadcastsToClassDurations { get; set; } = new Dictionary<RoleType, ushort>() { { RoleType.ClassD, 3 } };
    }
}

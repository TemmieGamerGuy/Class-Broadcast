using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBroadcast
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public Dictionary<RoleType, string> BroadcastsToClass { get; set; } = new Dictionary<RoleType, string>() { { RoleType.ClassD, "You are a prisoner slave good luck" } };

        public Dictionary<RoleType, ushort> BroadcastsToClassDurations { get; set; } = new Dictionary<RoleType, ushort>() { { RoleType.ClassD, 3 } };
    }
}

using Exiled.API.Enums;
using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Server = Exiled.Events.Handlers.Server;
using Player = Exiled.Events.Handlers.Player;

namespace ClassBroadcast
{
    public class ClassBroadcasts : Plugin<Config>
    {
        private static readonly Lazy<ClassBroadcasts> LazyInstance = new Lazy<ClassBroadcasts>(valueFactory: () => new ClassBroadcasts());
        public static ClassBroadcasts Instance => LazyInstance.Value;

        public override PluginPriority Priority { get; } = PluginPriority.Medium;

        private EventHandlers events;

        private ClassBroadcasts()
        {
        }

        public override void OnEnabled()
        {
            events = new EventHandlers();
            Player.Spawning += events.OnSpawning;
        }

        public override void OnDisabled()
        {
            Player.Spawning -= events.OnSpawning;
            events = null;
        }

        public void RegisterEvents()
        {

        }

        public void UnregisterEvents()
        {

        }
    }
}

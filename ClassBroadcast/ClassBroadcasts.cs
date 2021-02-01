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

        public static ClassBroadcasts Singleton;

        private EventHandlers events;

        public override string Author => "An4r3w & Sans";

        public override string Name { get; } = "Private Broadcast";
        
        public override string Prefix { get; } = "Private Broadcast"; 
        
        public override Version Version => new Version(1, 0, 2);
        
        public override Version RequiredExiledVersion => new Version(2, 1, 30);

        public override PluginPriority Priority => PluginPriority.Default;



        public override void OnEnabled()
        {
            Singleton = this;
            events = new EventHandlers();


            Player.Spawning += events.OnSpawning;
        }

        public override void OnDisabled()
        {
            base.OnEnabled();

            Player.Spawning -= events.OnSpawning;
            events = null;
        }
    }
}

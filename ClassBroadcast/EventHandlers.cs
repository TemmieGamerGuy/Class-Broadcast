using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System.Collections.Generic;
using System.Linq;

namespace ClassBroadcast
{
    public class EventHandlers
    {
        public void OnSpawning(SpawningEventArgs ev)
        {
            if (ClassBroadcasts.Singleton.Config.BroadcastsToClass.ContainsKey(ev.RoleType))
            {
                ev.Player.Broadcast(duration: ClassBroadcasts.Singleton.Config.BroadcastsToClassDurations[ev.RoleType], message: ClassBroadcasts.Singleton.Config.BroadcastsToClass[ev.RoleType]);
            }
        }
    }
}

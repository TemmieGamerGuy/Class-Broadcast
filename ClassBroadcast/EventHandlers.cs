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
            var config = ClassBroadcasts.Instance.Config;
            if (config.BroadcastsToClass.ContainsKey(ev.RoleType))
            {
                ev.Player.Broadcast(duration: config.BroadcastsToClassDurations[ev.RoleType], message: config.BroadcastsToClass[ev.RoleType]);
            }
        }
    }
}

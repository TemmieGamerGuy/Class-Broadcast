using Exiled.Events.EventArgs;

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

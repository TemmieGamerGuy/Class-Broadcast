using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBroadcast
{
    public class Methods
    {
        public static void ChaosBroadcast(Player Chaos)
        {
            Chaos.ReferenceHub.characterClassManager.NetworkCurClass = RoleType.ChaosInsurgency;
            Chaos.ClearBroadcasts();
            Chaos.Broadcast(15, ClassBroadcasts.Instance.Config.BroadcastChaos);
        }

        internal static void ChaosBroadcast()
        {
            throw new NotImplementedException();
        }
    }
}

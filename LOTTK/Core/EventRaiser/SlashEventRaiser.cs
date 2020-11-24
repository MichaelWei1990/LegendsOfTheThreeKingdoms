using System;
using System.Collections.Generic;
using System.Text;

namespace Core.EventRaiser
{
    public interface ISlashEventRaiser
    {
        Events.Slash RaiseSlashEvent(Player.Player user, Player.Player target);
    }
}

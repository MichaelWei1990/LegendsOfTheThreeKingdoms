using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Behaviour
{
    public interface ISlashAlternative
    {
        IList<Card.AbstractCard> Cards { get; set; }
        
        string GetHint();

        bool IsEventRaisable();

        Events.Slash RaiseSlashEvent(Player.Player user, Player.Player target);
    }
}

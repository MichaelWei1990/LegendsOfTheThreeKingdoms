using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public class Slash : Basic, EventRaiser.ISlashEventRaiser
    {
        public Slash(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        {
            Name = "殺";
        }

        public Events.Slash RaiseSlashEvent(Player.Player user, Player.Player target)
        {
            return new Events.Slash(user, target, new List<AbstractCard>() { this });
        }
    }
}

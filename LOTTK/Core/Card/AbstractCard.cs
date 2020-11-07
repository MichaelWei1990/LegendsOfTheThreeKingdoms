using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public abstract class AbstractCard
    {
        public Poker.Suit Suit { get; private set; }
        public Poker.Number Number { get; private set; }

        public AbstractCard(Poker.Suit suit, Poker.Number num) 
        {
            Suit = suit;
            Number = num;
        }

        public string GetPockerInfoString() 
        {
            return Util.EnumHelper.GetDescription(Number) + " of " + Util.EnumHelper.GetDescription(Suit);
        }
    }
}

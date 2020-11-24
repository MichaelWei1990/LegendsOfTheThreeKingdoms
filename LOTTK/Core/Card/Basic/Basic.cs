using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public abstract class Basic : AbstractCard
    {
        public Basic(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        { }
    }
}

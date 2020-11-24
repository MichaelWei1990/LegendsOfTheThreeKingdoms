using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public abstract class Armor : Equipment
    {
        public Armor(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public abstract class Weapon : Equipment
    {
        public int Range { get; protected set; }

        public Weapon(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        { }

    }
}

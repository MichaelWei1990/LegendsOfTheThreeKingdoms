using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public abstract class Equipment : AbstractCard
    {
        public Equipment(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        {}

        public abstract void EquipPlayer(Player.Player player);

        public abstract void UnequipPlayer(Player.Player player);

        protected void ShowEpuiptedInfo(Player.Player player) 
        {
            Console.WriteLine("Player has equiped with " + Name);
        }
    }
}

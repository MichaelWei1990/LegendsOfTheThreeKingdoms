using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    class BlackPommel : Weapon, Behaviour.IArmorNullifiable
    {
        public BlackPommel(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        {
            Name = "青釭劍";
            Range = 2;
        }

        public override void EquipPlayer(Player.Player user)
        {
            if (user == null) 
            {
                throw new ArgumentNullException("User is null.");
            }

            user.ArmorNullifier = this;
        }

        public override void UnequipPlayer(Player.Player user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null.");
            }

            Player.BehaviourRecoverer.RecoverArmorNullifier(user);
        }

        public bool IsArmorNullifiable(Player.Player target)
        {
            return true;
        }

    }
}

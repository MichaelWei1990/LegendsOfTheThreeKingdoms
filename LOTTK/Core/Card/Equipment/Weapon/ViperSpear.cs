using Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public class ViperSpear : Weapon, Behaviour.ISlashAlternative
    {
        private IList<AbstractCard> mCards;
        const int CARDS_NUM = 2;

        public IList<AbstractCard> Cards 
        { 
            get => mCards;
            set 
            {
                if (value == null || value.Count != CARDS_NUM)
                {
                    throw new ArgumentException("It must be two cards.");
                }

                mCards = value;
            }
        }

        public ViperSpear(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        {
            Name = "丈八蛇矛";
            Range = 3;
        }

        public override void EquipPlayer(Player.Player user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null.");
            }

            user.EquipmentsSection.Weapon = this;
            user.SlashAlternatives.SetAlternative(Player.SlashAlternatives.Priority.WEAPON, this);
            ShowEpuiptedInfo(user);
        }

        public Events.Slash RaiseSlashEvent(Player.Player user, Player.Player target)
        {
            // TODO: remove the cards from user's cards in hand

            // TODO: dispose cards to disposed card deck

            Events.Slash evnt = new Slash(user, target, Cards);
            user.UseSlashCard();
            return evnt;
        }

        public override void UnequipPlayer(Player.Player user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null.");
            }

            user.EquipmentsSection.Weapon = null;
            user.SlashAlternatives.RemoveAlternative(Player.SlashAlternatives.Priority.WEAPON);
        }

        public bool IsEventRaisable()
        {
            return Cards != null && Cards.Count == CARDS_NUM;
        }

        public string GetHint()
        {
            return "是否使用" + Name + "?";
        }
    }
}

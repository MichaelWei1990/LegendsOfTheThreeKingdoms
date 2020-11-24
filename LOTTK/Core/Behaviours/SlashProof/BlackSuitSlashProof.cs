using Core.Events;
using System;
using System.Collections.Generic;
using Core.Card;
using System.Linq;

namespace Core.Behaviour
{
    class BlackSuitSlashProof : ISlashProof
    {
        private static HashSet<Card.Poker.Suit> s_BlackSuits = new HashSet<Card.Poker.Suit>()
        {
            Card.Poker.Suit.CLUBS,
            Card.Poker.Suit.SPADES,
        };

        public object Clone()
        {
            return new BlackSuitSlashProof();
        }

        public bool IsSlashProof(Events.Slash evnt)
        {
            if (evnt == null)
            {
                throw new ArgumentNullException("Empty event.");
            }

            List<AbstractCard> cards = evnt.Cards as List<AbstractCard>;
            if (!cards.Any())
            {
                return false;
            }

            Card.Poker.Suit? suit = GetSuit(cards);
            return suit.HasValue ? s_BlackSuits.Contains(suit.Value) : false;
        }

        private Card.Poker.Suit? GetSuit(List<Card.AbstractCard> cards)
        {
            if (cards.Count == 1)
            {
                return cards.First().Suit;
            }

            Card.Poker.Suit suit = cards.First().Suit;
            bool isFirstCardSuitBlack = s_BlackSuits.Contains(suit);

            foreach (var card in cards.Skip(1))
            {
                bool isCardSuitBlack = s_BlackSuits.Contains(card.Suit);
                if (isFirstCardSuitBlack != isCardSuitBlack)
                {
                    return null;
                }
            }

            return suit;
        }
    }
}

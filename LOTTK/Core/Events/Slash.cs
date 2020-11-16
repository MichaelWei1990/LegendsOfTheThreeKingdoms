using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Events
{
    public class Slash
    {
        public Player.Player User { get; private set; }
        public Player.Player Target { get; private set; }
        public IList<Card.AbstractCard> Cards { get; private set; }        // there can be more than one cards for a slash, for example, if a player has equiped Viper Spear, s/he can use two cards as a slash
        public bool NullifyArmor { get; private set; } = false;

        public Slash(Player.Player user, Player.Player target, IList<Card.AbstractCard> cards) 
        {
            if (user == null || target == null) 
            {
                throw new ArgumentNullException("User and target cannot be null");
            }

            // TODO: verify if the user and target is the same player

            User = user;
            Target = target;
            Cards = cards;
            NullifyArmor = (user.ArmorNullifier != null);

        }
    }
}

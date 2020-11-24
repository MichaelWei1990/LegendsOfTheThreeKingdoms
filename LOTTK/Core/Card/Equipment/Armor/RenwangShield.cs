using Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Card
{
    public class RenwangShield : Armor
    {
     
        public Behaviour.ISlashProof SlashProof 
        {
            get; private set;
        }

        public RenwangShield(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        {
            Name = "仁王盾";
            SlashProof = new Behaviour.BlackSuitSlashProof();
        }

        public override void EquipPlayer(Player.Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("User is null.");
            }

            player.EquipmentsSection.Armor = this;
            player.SlashProofIdentifier = SlashProof.Clone() as Behaviour.ISlashProof;

            // TODO: erase all armor levels behaviours in the player
            // TODO: set armor and behaviours
            // TODO: set all skill level behaviours back
        }


        public override void UnequipPlayer(Player.Player player)
        {
            if (player == null)
            {
                throw new ArgumentNullException("User is null.");
            }

            player.EquipmentsSection.Armor = null;
            player.SlashProofIdentifier = null;
            

            // TODO: erase all armor levels behaviours in the player
            // TODO: set all skill level behaviours back
        }


    }
}

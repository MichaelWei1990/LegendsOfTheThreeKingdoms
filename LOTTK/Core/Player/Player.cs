using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Player
{
    public class Player
    {

        internal Behaviour.IArmorNullifiable ArmorNullifier { get; set; }
        internal Behaviour.ISlashCardUsable SlashCardUsableIdentifier { get; set; } = new Behaviour.DefaultSlashCardUsableIdentifier();
        internal Behaviour.ISlashProof SlashProofIdentifier { get; set; }

        internal Sections.EquipmentCards EquipmentsSection { get; private set; } = new Sections.EquipmentCards();

        internal SlashAlternatives SlashAlternatives { get; private set; } = new SlashAlternatives();
        public SlashAlternatives GetSlashAlternative()
        {
            return SlashAlternatives;
        }

        // Temp
        public bool PlayerRoundSlashUsed = false;
        public void StartRound() 
        {
            PlayerRoundSlashUsed = false;
            SlashCardUsableIdentifier.ResetUsableSlashCardNumber();
        }


        public void UseSlashCard() 
        {
            PostProcessSlashCardUsed();
            PlayerRoundSlashUsed = true;

            Console.WriteLine("Player used a slash card.");
        }

        public Events.Slash UseSlashCard(Card.Slash card, Player target) 
        {
            if (card == null || target == null) 
            {
                throw new ArgumentNullException("Slash card or target is null.");
            }

            if (target == this) 
            {
                throw new ArgumentException("Target cannot be the user.");
            }

            // TODO: add card to disposed card deck

            return card.RaiseSlashEvent(this, target);
        }


        public bool IsSlashCardUsable() 
        {
            Console.WriteLine("Slash card is usable: {0}", SlashCardUsableIdentifier.IsSlashCardUsable().ToString());
            return SlashCardUsableIdentifier.IsSlashCardUsable();
        }

        private void PostProcessSlashCardUsed() 
        {
            SlashCardUsableIdentifier.DeductUsableSlashCardNumber();
        }

        //public void EndRound()
        //{
        //    PlayerRoundSlashUsed = false;
        //    SlashCardUsableIdentifier.ResetUsableSlashCardNumber();
        //}

        public Respond.Slash OnSlashEventRespond(Events.Slash slashEvnt) 
        {
            if (SlashProofIdentifier != null && SlashProofIdentifier.IsSlashProof(slashEvnt))
            {
                return new Respond.Slash(Respond.Slash.Result.INEFFECTIVE);
            }

            Respond.Slash.Result result = Respond.Slash.Result.UNDOUGED;
            // TODO: respond with using douge card

            return new Respond.Slash(result);
        }
    }
}

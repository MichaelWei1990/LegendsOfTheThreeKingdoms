using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Player
{
    public class Player
    {

        internal Behaviour.IArmorNullifiable ArmorNullifier { get; set; }
        internal Behaviour.ISlashCardUsable SlashCardUsableIdentifier { get; set; } = new Behaviour.DefaultSlashCardUsableIdentifier();

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
    }
}

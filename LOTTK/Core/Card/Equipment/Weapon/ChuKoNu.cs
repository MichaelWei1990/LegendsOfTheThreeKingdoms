using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Card
{
    public class ChuKoNu : Weapon
    {
        readonly Behaviour.UnlimitedSlashCardRaiser mUnlimitedSlashCardRaiser = new Behaviour.UnlimitedSlashCardRaiser();
        public ChuKoNu(Poker.Suit suit, Poker.Number num) :
            base(suit, num)
        {
            Name = "諸葛連弩";
            Range = 1;
        }

        public override void EquipPlayer(Player.Player user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null.");
            }

            user.EquipmentsSection.Weapon = this;
            user.SlashCardUsableIdentifier = mUnlimitedSlashCardRaiser;
            user.SlashCardUsableIdentifier.ResetUsableSlashCardNumber();

            ShowEpuiptedInfo(user);
        }

        public override void UnequipPlayer(Player.Player user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("User is null.");
            }

            user.EquipmentsSection.Weapon = null;
            Player.BehaviourRecoverer.RecoverSlashCardUsableIdentifier(user);
        }
    }
}

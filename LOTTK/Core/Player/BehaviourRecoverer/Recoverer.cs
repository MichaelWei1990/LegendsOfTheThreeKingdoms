using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Player
{
    public static class BehaviourRecoverer
    {
        public static void RecoverArmorNullifier(Player target) 
        {
            if (target == null) 
            {
                throw new ArgumentNullException("Target is null.");
            }

            target.ArmorNullifier = null;   // set the nullfier to null first

            // TODO: go through other possible source from target and set it back if there's any option avaiable

        }

        public static void RecoverSlashCardUsableIdentifier(Player target) 
        {
            if (target == null)
            {
                throw new ArgumentNullException("Target is null.");
            }

            target.SlashCardUsableIdentifier = new Behaviour.DefaultSlashCardUsableIdentifier(target.PlayerRoundSlashUsed);

            // TODO: go through other possible source from target and set it back if there's any option avaiable
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Behaviour
{
    class DefaultSlashCardUsableIdentifier : ISlashCardUsable
    {
        public int UsableSlashCardNumber { get; private set; } = 0;

        public DefaultSlashCardUsableIdentifier(bool playerUsedSlashInHisRound = false) 
        {
            UsableSlashCardNumber = playerUsedSlashInHisRound ? 0 : 1;
        }

        public void DeductUsableSlashCardNumber()
        {
            if (UsableSlashCardNumber > 0)
            {
                --UsableSlashCardNumber;
            }       
        }

        public bool IsSlashCardUsable()
        {
            return UsableSlashCardNumber > 0;
        }

        public void ResetUsableSlashCardNumber()
        {
            UsableSlashCardNumber = 1;
        }
    }
}

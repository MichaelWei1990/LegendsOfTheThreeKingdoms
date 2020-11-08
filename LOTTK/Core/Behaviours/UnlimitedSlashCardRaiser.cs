using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Behaviour
{
    class UnlimitedSlashCardRaiser : ISlashCardUsable
    {
        const int MAX_SLASH_CARDS_NUM = 1000;
        public int UsableSlashCardNumber { get; private set; } = MAX_SLASH_CARDS_NUM;

        public void DeductUsableSlashCardNumber()
        {
            if (UsableSlashCardNumber <= 0)
            {
                Console.WriteLine("Wow, how could this happen.");
            }

            --UsableSlashCardNumber;
        }

        public bool IsSlashCardUsable()
        {
            return UsableSlashCardNumber > 0;
        }

        public void ResetUsableSlashCardNumber()
        {
            UsableSlashCardNumber = MAX_SLASH_CARDS_NUM;          // When a player equiped with ChuKoNu, they can use as many slash card as they want. here sets a very large number
        }
    }
}

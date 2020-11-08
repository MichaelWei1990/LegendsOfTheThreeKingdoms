using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Behaviour
{
    public interface ISlashCardUsable
    {
        int UsableSlashCardNumber 
        {
            get;
        }

        void ResetUsableSlashCardNumber();

        bool IsSlashCardUsable();

        void DeductUsableSlashCardNumber();
    }
}

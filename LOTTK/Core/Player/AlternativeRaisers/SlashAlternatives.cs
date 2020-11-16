using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace Core.Player
{
    public class SlashAlternatives
    {
        public enum Priority 
        {
            SKILL = 0,
            WEAPON = 1,
        }

        private OrderedDictionary mAlternatives = new OrderedDictionary();

        public void SetAlternative(Priority priority, Behaviour.ISlashAlternative alternate) 
        {
            if (!mAlternatives.Contains(priority)) 
            {
                mAlternatives.Add(priority, alternate);
                return;
            }

            mAlternatives[priority] = alternate;
        }

        public void RemoveAlternative(Priority priority) 
        {
            if (!mAlternatives.Contains(priority))
            {
                throw new ArgumentException("Slash alternative not exists.");
            }

            mAlternatives.Remove(priority);
        }

        public Behaviour.ISlashAlternative GetAlternate() 
        {
            if (!HasAlternate()) 
            {
                throw new InvalidOperationException("Doesn't have alternates.");
            }

            Behaviour.ISlashAlternative[] alternates = new Behaviour.ISlashAlternative[mAlternatives.Count];
            mAlternatives.Values.CopyTo(alternates, 0);
            return alternates[0];
        }

        public bool HasAlternate() 
        {
            return mAlternatives.Count > 0;
        }

    }
}

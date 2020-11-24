using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Behaviour
{
    public interface ISlashProof: ICloneable
    {
        bool IsSlashProof(Events.Slash evnt);
    }
}

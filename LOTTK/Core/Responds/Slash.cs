using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Respond
{
    public class Slash
    {
        public enum Result 
        {
            INEFFECTIVE = 0,
            DOUGED = 1,
            UNDOUGED = 2,
        }

        public Result ResponsiveResult { get; private set; }

        public Slash(Result result) 
        {
            ResponsiveResult = result;
        }

    }
}

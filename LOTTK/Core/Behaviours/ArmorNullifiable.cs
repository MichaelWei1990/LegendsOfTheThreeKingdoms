using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Behaviour
{
    public interface IArmorNullifiable
    {
        bool IsArmorNullifiable(Player.Player player);
    }
}

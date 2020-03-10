using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewAnglePlugin.Models
{
    public class ViewAngelHelper
    {
        public bool TryViewAngle(UnturnedPlayer caller, out float pitch)
        {
            pitch = default;
            var player = (UnturnedPlayer)caller;
            if (player.CurrentVehicle == null)
                return false;
            pitch = player.Player.look.pitch;
            return true;
        }
    }
}
